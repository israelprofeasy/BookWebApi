using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class AuthorRepository : IAuthor
    {
        private readonly BookDbContext _ctx;

        public AuthorRepository(BookDbContext ctx)
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

        public async Task<Author> GetAuthorById(string id)
        {
            return await _ctx.Author.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _ctx.Author.ToListAsync();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.Author.CountAsync();
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
