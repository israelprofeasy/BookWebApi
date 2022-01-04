using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class Book_AuthorRepository : IBook_AuthorRepository
    {
        private readonly BookDbContext _ctx;

        public Book_AuthorRepository(BookDbContext bookDbContext)
        {
            _ctx = bookDbContext;
        }
        public async Task<bool> Add<T>(T entity)
        {
            await _ctx.AddAsync(entity);
            return await SaveChanges();
        }

        public async Task<IEnumerable<Author>> AuthorsOfBook(string bookId)
        {
            return await _ctx.Book_Author.Where(x => x.BookId == bookId).Include(x => x.Author).Select(x => x.Author).ToListAsync();
        }

        public async Task<IEnumerable<Book>> BooksOfAuthor(string authorId)
        {
            return await _ctx.Book_Author.Where(x => x.AuthorId == authorId).Include(x=>x.Book).Select(x=>x.Book).ToListAsync();
        }

        public async Task<bool> Delete<T>(T entity)
        {
            _ctx.Remove(entity);
            return await SaveChanges();
        }

        public async Task<Book_Author> GetBook_Author(string bookId, string authorId)
        {
            return await _ctx.Book_Author.Where(x => x.BookId == bookId && x.AuthorId == authorId).FirstOrDefaultAsync();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.Book_Author.CountAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return await _ctx.SaveChangesAsync() > 0 ;
        }

        public async  Task<bool> Update<T>(T entity)
        {
             _ctx.Update(entity);
            return await SaveChanges();
        }
    }
}
