using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PDFMaestro.Models
{
    public class DataModelEntityConfig : IEntityTypeConfiguration<SwapiCharacterModel>
    {
        public void Configure(EntityTypeBuilder<SwapiCharacterModel> builder)
        {
            builder
                .Property(x => x.Name)
                .HasColumnType("nvarchar(100)");

            builder
                .Property(x => x.BirthYear)
                .HasColumnType("nvarchar(20)");

            builder
                .Property(x => x.Height)
                .HasColumnType("nvarchar(20)");

            builder
                .Property(x => x.Weight)
                .HasColumnType("nvarchar(20)");

            builder
                .Property(x => x.Gender)
                .HasColumnType("nvarchar(20)");
        }
    }
}
