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
        private IAppUserService _service;
        public UsersController(IAppUserService service)
        {
            //Dependency Injection
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetAsync()
        {
            return await _service.GetUsersAsync();
        }

        [HttpGet("{id}")]
        public async Task<AppUser> GetUserAsync(int id)
        {
            return await _service.GetUserAsync(id);
        }

        [HttpPost]
        public async Task AddAsync(AppUser user)
        {
            await _service.AddUserAsync(user);
        }

    }
}
