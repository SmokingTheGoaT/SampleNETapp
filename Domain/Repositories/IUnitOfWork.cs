using System.Threading.Tasks;

namespace SampleNETapp.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}