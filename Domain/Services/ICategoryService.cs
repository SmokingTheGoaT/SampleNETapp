using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;

namespace SampleNETapp.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}