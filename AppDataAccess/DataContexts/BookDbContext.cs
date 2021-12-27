using BookWebApi.AppModels.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookWebApi.AppDataAccess.DataContexts
{
    public class BookDbContext : IdentityDbContext<AppUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<FavouriteBook> FavoriteBook { get; set;}
        public DbSet<Category> Category { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<Book_Author> Book_Author { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            
            builder.Entity<FavouriteBook>().HasOne(x => x.Book).WithMany(c => c.FavouriteUsers).HasForeignKey(d => d.BookId);
            builder.Entity<FavouriteBook>().HasOne(x => x.AppUser).WithMany(c => c.FavoriteBooks).HasForeignKey(d => d.AppUserId);
            builder.Entity<Book_Author>().HasOne(x => x.Book).WithMany(c => c.Book_Authors).HasForeignKey(d => d.BookId);
            builder.Entity<Book_Author>().HasOne(x => x.Author).WithMany(c => c.Book_Authors).HasForeignKey(d => d.AuthorId);
        }
    }
}
