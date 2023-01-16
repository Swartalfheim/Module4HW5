using M4HW3.Configurats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.TitleId).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new List<Title>()
            {
                new Title() { TitleId = 1, Name = "En" },
                new Title() { TitleId = 2, Name = "To" },
                new Title() { TitleId = 3, Name = "Tre" },
            });
        }
    }
}
