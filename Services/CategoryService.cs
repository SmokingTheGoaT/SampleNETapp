using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;
using SampleNETapp.Domain.Services;
using SampleNETapp.Domain.Repositories;

namespace SampleNETapp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}