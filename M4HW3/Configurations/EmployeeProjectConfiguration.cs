using M4HW3.Configurats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnType("money");
            builder.Property(e => e.StartedDate).IsRequired();
            builder.HasOne(e => e.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Project)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<EmployeeProject>()
            {
                new EmployeeProject() { EmployeeProjectId = 1, Rate = 256, StartedDate = DateTime.Now, EmployeeId = 1, ProjectId = 1 },
                new EmployeeProject() { EmployeeProjectId = 2, Rate = 600, StartedDate = DateTime.Now, EmployeeId = 2, ProjectId = 2 },
                new EmployeeProject() { EmployeeProjectId = 3, Rate = 300, StartedDate = DateTime.Now, EmployeeId = 3, ProjectId = 3 },
            });
        }
    }
}
