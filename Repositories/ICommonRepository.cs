using System.Threading.Tasks;
using ImageAPI.Models;

namespace ImageAPI.Repositories
{
    public interface ICommonRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<Photo> GetPhoto(int id);
    }
}