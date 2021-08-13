using ModelClient.Data;
using ModelClient.Mapper;
using ModelGlobal.Data;
using ModelGlobal.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public class CategoryClientService : IRepoCategory<CategoryClient>
    {
        private IRepoCategory<CategoryGlobal> _catGlobalService;

        public CategoryClientService()
        {
            _catGlobalService = new CategoryGlobalService();
        }

        public bool Delete(int id)
        {
            return _catGlobalService.Delete(id);
        }

        public IEnumerable<CategoryClient> Get()
        {
            return _catGlobalService.Get().Select(c => c.ToCategoryClient());
        }

        public CategoryClient Get(int id)
        {
            return _catGlobalService.Get(id)?.ToCategoryClient();
        }

        public int Post(CategoryClient category)
        {
            return _catGlobalService.Post(category.ToCategoryGlobal());
        }

        public bool Put(int id, CategoryClient category)
        {
            return _catGlobalService.Put(id, category.ToCategoryGlobal());
        }
    }
}
