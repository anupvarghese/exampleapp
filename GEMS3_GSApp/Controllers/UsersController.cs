using GEMS3_GSApp.KendoUiModels;
using GEMS3_GSApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.OData;

namespace GEMS3_GSApp.Controllers
{
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
}
