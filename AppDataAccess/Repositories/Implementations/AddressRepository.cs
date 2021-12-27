using BookWebApi.AppDataAccess.DataContexts;
using BookWebApi.AppDataAccess.Repositories.Interfaces;
using BookWebApi.AppModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly BookDbContext _ctx;

        public AddressRepository(BookDbContext ctx)
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

        public async Task<Address> GetAddress(string userId)
        {
            //return await _ctx.Address.Where(x => x.AppUserId== userId).FirstOrDefaultAsync();
            return await _ctx.Address.Include(x => x.AppUser).FirstAsync(x => x.AppUserId == userId);
        }

        public async Task<IEnumerable<Address>> GetAllAddress()
        {
            return await _ctx.Address.ToListAsync();
        }

        public async Task<int> RowCount()
        {
            return await _ctx.Address.CountAsync();
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
