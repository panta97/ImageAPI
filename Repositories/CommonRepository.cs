using System.Threading.Tasks;
using ImageAPI.Data;
using ImageAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageAPI.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly DataContext _context;
        public CommonRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            return photo;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}