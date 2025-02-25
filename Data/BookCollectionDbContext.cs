using Microsoft.EntityFrameworkCore;
using Moment3_ASPNET.Models;

namespace Moment3_ASPNET.Data
{
    //ärver från DbContext, dvs fungerar som en databaskoppling
    public class BookCollectionDbContext: DbContext
    {
        public BookCollectionDbContext(DbContextOptions<BookCollectionDbContext> options) : base(options)
        {

        }

        //representerar tabell för böcker
        public DbSet<BookModel> Books { get; set; }

        //representerar tabell för författare
        public DbSet<AuthorModel> Authors { get; set; }
    }
}
