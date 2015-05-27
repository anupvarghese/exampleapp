GEMS3 GS Application
=============

Please use Raw view to see Markdown.

Components used
-------

* Autofac for dependency injection
* Postal for email services
* Log4net for logger
* Bower & Grunt for client side libraries
* Entity framework 6.1
* Moq.NET for creating mock tests
* .NET 4.5
* oData
* Kendo UI


Bower & grunt Installation
-------
1. `npm install bower -g`
2. `bower init`
3. create ``.bowerrc` file and add following content
```javascript
{
		directory : Content/bower_components
}
```
4. Install packages as below
```
bower install <package> save
```
5. `npm install grunt-cli -g`
6. `npm init`
7. `npm install grunt`
8. `npm install grunt-wiredep`
9. Add `gruntfile.js` file with below settings
```javascript
module.exports = function (grunt) {
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        wiredep: {
            target: {
                src: [
                    'App_Start/BundleConfig.cs'
                ],
                ignorePath: '..',
                fileTypes: {
                    cs: {
                        block: /(([ \t]*)\/\/\s*bower:*(\S*)\s*)(\n|\r|.)*?(\/\/\s*endbower\s*)/gi,
                        detect: {
                            js: /<script.*src=['"](.+)['"]>/gi,
                            css: /<link.*href=['"](.+)['"]/gi
                        },
                        replace: {
                            js: '.Include("~{{filePath}}")',
                            css: '.Include("~{{filePath}}")',
                        },
                    }
                },
                dependencies: true,
                devDependencies: false,
            }
        },
    });
    grunt.loadNpmTasks('grunt-wiredep');
    grunt.registerTask('default', ['wiredep']);
};
```
10. Edit `bundleconfig.cs` as below
```csharp
bundles.Add(new ScriptBundle("~/bundles/bowerjs")
	             // bower:js
	             // endbower
	         );
bundles.Add(new StyleBundle("~/bundles/bowercss")
	             // bower:css
	             // endbower
           );
```
11. type `grunt` & run
12. `Bundleconfig.cs` will now get updated
13. Kendo UI Bower file update
```javascript
"main": [
      "js/kendo.all.min.js",
      "styles/kendo.common-bootstrap.min.css",
      "styles/kendo.default.min.css",
      "styles/kendo.bootstrap.min.css",
      "styles/kendo.dataviz.bootstrap.min.css",
      "styles/kendo.dataviz.default.min.css"
  ],
```

Kendo UI and OData Integration
-------

1. Install WebApi.OData package from nuget
```
PM> Install-Package Microsoft.AspNet.WebApi.OData
```
2. Prepare custom model
```csharp
public class User
{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
}
```
3. Create new Api controller as follows (inherit it from `ODataController` class)
```csharp
public class UsersController : ODataController
{
		private readonly IUserService _userService;
		public UsersController(IUserService userService)
		{
				_userService = userService;
		}

		// GET api/<controller>
		[EnableQuery]
		public IQueryable<User> Get()
		{
				var items = _userService.GetAll();
				return (from n in items
								select new User
								{
										Email = n.Email,
										Id = n.Userid,
										Username = n.Username
								}).AsQueryable();
		}
}
```
4. Remeber the `IQueryable`
5. Create a view (HTML or Razor) and add the below code
```javascript
<div id="grid"></div>
<script type="text/javascript">
    $(function () {
        var dataSource = new kendo.data.DataSource({
            type: "odata",
            transport: {
                read: {
                    url: "/api/Users",
                    dataType: "json"
                },
            },
            schema: {
                data: function (data) {
                    return data["value"];
                },
                total: function (data) {
                    return data["odata.count"];
                },
                model: {
                    fields: {
                        Id: { type: "number" },
                        Username: { type: "string" },
                        Email: { type: "string" }
                    }
                }
            },
            pageSize: 10,
            reorderable: true,
            serverPaging: true,
            serverFiltering: true,
            serverSorting: true

        });

        $("#grid").kendoGrid({
            dataSource: dataSource,
            reorderable: true,
            groupable: true,
            resizable: true,
            filterable: true,
            columnMenu: true,
            pageable: true,
            scrollable: true,
            filterable: {
                extra: false,
                operators: {
                    string: {
                        startswith: "Starts with",
                        eq: "Is equal to",
                        neq: "Is not equal to",
                        contains: "Contains",
                        endswith: "Endswith"
                    }
                }
            },
            columns:
                [{
                    field: "Id",
                    filterable: false
                },
                {
                    field: "Username"
                },
                {
                    field: "Email"
                }]
        });
    });
</script>
```

Developer
------------
Anoop Varghese
