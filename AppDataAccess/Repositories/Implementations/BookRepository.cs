using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _ctx;

        public BookRepository(BookDbContext ctx)
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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _ctx.Book.ToListAsync();
        }

        public async Task<Book> GetBookById(string id)
        {
            return await _ctx.Book.Where(x => x.Id ==id).FirstOrDefaultAsync();
        }

        public async Task<Book> GetBookByISBN(string isbn)
        {
            return await _ctx.Book.Where(x =>x.ISBN == isbn).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Book>> GetBookByName(string name)
        {
            return await _ctx.Book.Where(x => x.Title.Contains(name)).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthor(string authorId)
        {
            return await _ctx.Book_Author.Where(x => x.AuthorId == authorId).Include(c => c.Book).Select(c => c.Book).ToListAsync();
            
        }

        public async Task<IEnumerable<Book>> GetBooksByCategory(string categoryId)
        {
            return await _ctx.Book.Where(x => x.CategoryId == categoryId).ToListAsync();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.Book.CountAsync();
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
