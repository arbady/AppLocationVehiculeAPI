using LocationVehicule.API.Mapper;
using LocationVehicule.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClient.Data;
using ModelClient.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        //private ModelClientService _modelService = new ModelClientService();
        private readonly IRepoModel<ModeleClient> _modelService;
        public ModelController(IRepoModel<ModeleClient> modelService)
        {
            _modelService = modelService;
        }

        // GET: api/Model
        [HttpGet]
        public IEnumerable<ModelApi> Get()
        {
            return _modelService.Get().Select(m => m.ToModelApi());
        }

        // GET: api/Model/3
        [HttpGet("{id:int}")]
        public ModelApi Get(int id)
        {
            return _modelService.Get(id).ToModelApi();
        }

        // POST: api/Model
        [HttpPost]
        public int Post([FromBody] ModelApi model)
        {
            return _modelService.Post(model.ToModelClient());
        }

        // PUT: api/Model/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] ModelApi model)
        {
            return _modelService.Put(id, model.ToModelClient());
        }

        // DELETE: api/Model/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _modelService.Delete(id);
        }
    }
}
