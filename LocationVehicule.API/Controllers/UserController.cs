using LocationVehicule.API.Mapper;
using LocationVehicule.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelClient.Data;
using ModelClient.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocationVehicule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class UserController : ControllerBase
    {
        //private UserClientService _userService = new UserClientService();
        private readonly IRepoUser<UserClient> _userService;
        public UserController(IRepoUser<UserClient> userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserApi> Get()
        {
            return _userService.Get().Select(u => u.ToUserApi());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserApi Get(int id)
        {
            return _userService.Get(id).ToUserApi();
        }

        // POST api/<UserController>
        [HttpPost]
        public int Post([FromBody] UserApi user)
        {
            return _userService.Post(user.ToUserApi());
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] UserApi user)
        {
            return _userService.Put(id, user.ToUserApi());
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }
    }
}
