using M4HW3.Configurats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.OfficeId).ValueGeneratedOnAdd();
            builder.Property(o => o.Title).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasMaxLength(100);

            builder.HasData(new List<Office>()
            {
                new Office() { OfficeId = 1, Title = "Kapitalist", Location = "Kharkiv" },
                new Office() { OfficeId = 2, Title = "Steklo", Location = "Oslo" },
                new Office() { OfficeId = 3, Title = "Magelan", Location = "Nuuk" },
            });
        }
    }
}
