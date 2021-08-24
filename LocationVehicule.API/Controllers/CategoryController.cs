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
        public IEnumerable<CategoryClient> Get()
        {
            return _categoryService.Get();
        }

        // GET: api/Category/3
        [HttpGet("{id:int}")]
        public CategoryClient Get(int id)
        {
            return _categoryService.Get(id);
        }

        // POST: api/Category
        [HttpPost]
        public int Post([FromBody] CategoryClient category)
        {
            return _categoryService.Post(category);
        }

        // PUT: api/Category/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] CategoryClient category)
        {
            return _categoryService.Put(id, category);
        }

        // DELETE: api/Category/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _categoryService.Delete(id);
        }
    }
}
