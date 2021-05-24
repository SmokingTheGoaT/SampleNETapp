using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleNETapp.Domain.Models;
using SampleNETapp.Domain.Services;

namespace SampleNETapp.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetALlAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}