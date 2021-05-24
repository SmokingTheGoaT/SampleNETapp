using System.Threading.Tasks;
using SampleNETapp.Domain.Repositories;
using SampleNETapp.Persistance.Contexts;

namespace SampleNETapp.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}