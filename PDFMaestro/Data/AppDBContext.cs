using Microsoft.EntityFrameworkCore;
using PDFMaestro.Models;

namespace PDFMaestro.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<SwapiCharacterModel> SwapiCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DataModelEntityConfig().Configure(modelBuilder.Entity<SwapiCharacterModel>());
        }
    }
}
