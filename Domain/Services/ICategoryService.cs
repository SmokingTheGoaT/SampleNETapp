using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;
using SampleNETapp.Domain.Services.Communication;
using SampleNETapp.Resources;

namespace SampleNETapp.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}