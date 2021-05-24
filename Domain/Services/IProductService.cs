using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;
using SampleNETapp.Domain.Services.Communication;

namespace SampleNETapp.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}