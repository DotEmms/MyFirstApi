using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class UsersController : ControllerBase
    {
        private AppUserService _service;
        public UsersController()
        {
            _service = new AppUserService();
        }

        [HttpGet]
        public IEnumerable<AppUser> Get()
        {
            return _service.GetUsers();
        }

        [HttpPost]
        public void Add(AppUser user)
        {
            _service.AddUser(user);
        }

    }
}
