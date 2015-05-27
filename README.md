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

Installation
-----------

```
Bower & grunt Installation
```

1. 	`npm install bower -g`
2. 	`bower init`

3. create ``.bowerrc` file and add following content

```javascript
{
		directory : Content/bower_components
}
```
4. Install packages as below

	`bower install <package> save`

5. `npm install grunt-cli -g`

6. `npm init`

7. `npm install grunt`

8. `npm install grunt-wiredep`

9. Add `gruntfile.js` file with below settings

	```javascript
	module.exports = function(grunt) {
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

		bundles.Add(new ScriptBundle("~/bundles/bowerjs")
	                // bower:js
	                // endbower
	        );

		bundles.Add(new StyleBundle("~/bundles/bowercss")
	                // bower:css
	                // endbower
                );

11. type `grunt` & run

12. `Bundleconfig.cs` will now be updated

```
Kendo UI Bower file update
```

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

```
More to add in below...
```
Developer
------------

Anoop Varghese
