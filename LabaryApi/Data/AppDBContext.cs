using LabaryApi.Modele;
using Microsoft.EntityFrameworkCore;

namespace LabaryApi.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options) { }

    }
}
