using M4HW3.Configurats;
using M4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.EmployeeId).ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired();
            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Title)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Employee>()
            {
                new Employee() { EmployeeId = 1, FirstName = "Denys", LastName = "Shapka", HiredDate = DateTime.Now, DateOfBirth = new DateOnly(2000, 1, 27), OfficeId = 1, TitleId = 1 },
                new Employee() { EmployeeId = 2, FirstName = "Dima", LastName = "Kormyshov", HiredDate = DateTime.Now, DateOfBirth = new DateOnly(2001, 6, 21), OfficeId = 2, TitleId = 2 },
                new Employee() { EmployeeId = 3, FirstName = "Nikita", LastName = "Petrov", HiredDate = DateTime.Now, DateOfBirth = new DateOnly(2001, 3, 15), OfficeId = 3, TitleId = 3 },
            });
        }
    }
}
