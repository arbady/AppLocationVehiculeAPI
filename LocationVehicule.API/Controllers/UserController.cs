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
    //[Authorize(Roles = "Admin")]
    public class UserController : ControllerBase
    {
        //private UserClientService _userService = new UserClientService();
        private readonly IRepoUser<UserClient> _userService;
        private readonly IRepoLicence<LicenceClient> _licenceService;

        public UserController(IRepoUser<UserClient> userService, IRepoLicence<LicenceClient> licenceService)
        {
            _userService = userService;
            this._licenceService = licenceService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserClient> Get()
        {
            return _userService.Get();
        }

        //// GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public UserClient Get(int id)
        //{
        //    return _userService.Get(id);
        //}

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserClient Get(int id, bool licence)
        {
            UserClient result = null;
            if (id > 0) result  = _userService.Get(id);
            if (licence) result.Licences = _licenceService.GetForUser(result.Id);
            return result;
        }

        // POST api/<UserController>
        [HttpPost]
        public int Post([FromBody] UserClient user)
        {
            return _userService.Post(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] UserClient user)
        {
            return _userService.Put(id, user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _userService.Delete(id);
        }
    }
}
