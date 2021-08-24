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
    public class CategoryController : ControllerBase
    {
        //private CategoryClientService _categoryService = new CategoryClientService();
        private readonly IRepoCategory<CategoryClient> _categoryService;
        public CategoryController(IRepoCategory<CategoryClient> categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<CategoryApi> Get()
        {
            return _categoryService.Get().Select(c => c.ToCategoryApi());
        }

        // GET: api/Category/3
        [HttpGet("{id:int}")]
        public CategoryApi Get(int id)
        {
            return _categoryService.Get(id).ToCategoryApi();
        }

        // POST: api/Category
        [HttpPost]
        public int Post([FromBody] CategoryApi category)
        {
            return _categoryService.Post(category.ToCategoryClient());
        }

        // PUT: api/Category/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] CategoryApi category)
        {
            return _categoryService.Put(id, category.ToCategoryClient());
        }

        // DELETE: api/Category/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _categoryService.Delete(id);
        }
    }
}
