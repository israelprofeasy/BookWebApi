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

        public async Task<IEnumerable<AppUser>> BookFavoriteUsers(string bookId)
        {
            return await _ctx.FavoriteBook.Where(x => x.BookId == bookId).Include(x => x.AppUser).Select(x => x.AppUser).ToListAsync();
        }

        public async Task<bool> Delete<T>(T entity)
        {
            _ctx.Remove(entity);
            return await SaveChanges();

        }

        public async Task<IEnumerable<Book>> GetFavoriteUserBooks(string userId)
        {
            //var response = _ctx.FavoriteBook.Where(x => x.AppUserId == userId);
            //return await _ctx.Book.Where(x => response.Any(y => x.Id==y.BookId)).ToListAsync();

            return await _ctx.FavoriteBook.Where(x => x.AppUserId == userId).Include(x => x.Book).Select(x => x.Book).ToListAsync();
        }

        public async Task<IEnumerable<AppUser>> GetFavoriteUserBooksByCity(string city)
        {
            return await _ctx.FavoriteBook.Include(x => x.AppUser).Select(x => x.AppUser).Include(x => x.Address).Where(x => x.Address.City == city).ToListAsync();
        }

        public async Task<IEnumerable<AppUser>> GetFavoriteUserBooksByCountry(string country)
        {
            return await _ctx.FavoriteBook.Include(x => x.AppUser).Select(x => x.AppUser).Include(x => x.Address).Where(x => x.Address.Country == country).ToListAsync();
        }

        public async Task<FavouriteBook> GetFavouriteBook(string userId, string bookId)
        {
            return await _ctx.FavoriteBook.Where(x => x.AppUserId == userId && x.BookId == bookId).FirstOrDefaultAsync();
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
