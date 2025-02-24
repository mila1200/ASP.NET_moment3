using Microsoft.EntityFrameworkCore;
using Moment3_ASPNET.Models;

namespace Moment3_ASPNET.Data
{
    public class BookCollectionDbContext: DbContext
    {
        public BookCollectionDbContext(DbContextOptions<BookCollectionDbContext> options) : base(options)
        {

        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
    }
}
