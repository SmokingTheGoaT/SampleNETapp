using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;

namespace SampleNETapp.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}