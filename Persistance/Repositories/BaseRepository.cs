using SampleNETapp.Persistance.Contexts;

namespace SampleNETapp.Persistance.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}