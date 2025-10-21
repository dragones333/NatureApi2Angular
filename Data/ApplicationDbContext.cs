using Microsoft.EntityFrameworkCore;

namespace NatureApi2.Data
{
    // Asegúrate de tener tus modelos en este namespace o ajusta el using
    using NatureApi2.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets para tus tablas
        public DbSet<Place> Places { get; set; } = null!;
        public DbSet<Trail> Trails { get; set; } = null!;
    }
}