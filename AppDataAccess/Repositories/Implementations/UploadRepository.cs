using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class UploadRepository : IUploadRepository
    {
        private readonly BookDbContext _ctx;

        public UploadRepository(BookDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<bool> Add<T>(T entity)
        {
            await _ctx.AddAsync(entity);
            return await SaveChanges();
        }

        public async Task<bool> Delete<T>(T entity)
        {
            _ctx.Remove(entity);
            return await SaveChanges();
        }

        public async Task<IEnumerable<Upload>> GetAllUploads()
        {
            return await _ctx.Uploads.ToListAsync();
        }

        public async Task<Upload> GetUpload(string bookId)
        {
            return await _ctx.Uploads.Where(x => x.BookId == bookId).FirstOrDefaultAsync();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.Uploads.CountAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return await _ctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update<T>(T entity)
        {
            _ctx.Update(entity);
            return await SaveChanges();
        }
    }
}
