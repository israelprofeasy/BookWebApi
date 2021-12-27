using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class FavoriteRepository : IFavoriteBook
    {
        private readonly BookDbContext _ctx;

        public FavoriteRepository(BookDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<bool> Add<T>(T entity)
        {
            await _ctx.AddAsync(entity);
            return await SaveChanges();
        }

        public Task<IEnumerable<AppUser>> BookFavoriteUsers(string bookId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Delete<T>(T entity)
        {
            _ctx.Remove(entity);
            return await SaveChanges();

        }

        public async Task<IEnumerable<Book>> GetFavoriteUserBooks(string userId)
        {
            var response = _ctx.FavoriteBook.Where(x => x.AppUserId == userId);
            return await _ctx.Book.Where(x => response.Any(y => x.Id==y.BookId)).ToListAsync();
            //throw new System.NotImplementedException();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.FavoriteBook.CountAsync();
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
