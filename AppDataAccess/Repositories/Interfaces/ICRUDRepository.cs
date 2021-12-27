using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Interfaces
{
    public interface ICRUDRepository
    {
        Task<bool> Add<T>(T entity);
        Task<bool> Delete<T>(T entity);
        Task<bool> Update<T>(T entity);
        Task<bool> SaveChanges();
        Task<int> RowCount();

    }
}
