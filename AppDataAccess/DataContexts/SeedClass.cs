using BookWebApi.AppModels.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.AppDataAccess.DataContexts
{
    public class SeedClass
    {
        private readonly BookDbContext _ctx;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedClass(BookDbContext ctx, UserManager<AppUser> user, RoleManager<IdentityRole> role)
        {
            _ctx = ctx;
            _userManager = user;
            _roleManager = role;
        }
        public async Task SeedMe()
        {
            _ctx.Database.EnsureCreated();
            try
            {
                var roles = new string[] { "Regular", "Admin" };
                if (!_roleManager.Roles.Any())
                {
                    foreach(var role in roles)
                    {
                        await _roleManager.CreateAsync(new IdentityRole(role));
                    }
                }
               // var bookData = System.IO.File.ReadAllText("AppDataAccess/DataContexts/SeedBook.json");
                var userData = System.IO.File.ReadAllText("AppDataAccess/DataContexts/SeedUser.json");
               // var listofBook = JsonConvert.DeserializeObject<List<Book>>(bookData);
                var listofuser = JsonConvert.DeserializeObject<List<AppUser>>(userData);
                if (!_userManager.Users.Any())
                {
                    var counter = 0;
                    var role = "";
                    foreach(var user in listofuser)
                    {
                        user.UserName = user.Email;
                        role = counter < 1 ? roles[1] : roles[0];
                        var res = await _userManager.CreateAsync(user, "P@ssw0rd");
                        if (res.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(user, role);
                        }

                        counter++;
                    }
                    

                }
                //if (!_ctx.Book.Any())
                //{
                //    for
                //}
            }
            catch(DbException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
