using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers 
{
    public class ProjectMapper: EntityTypeConfiguration<Project>
    {
        public ProjectMapper()
        {
            ToTable("Projects");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Title).IsOptional();
            Property(p => p.Title).HasMaxLength(100);

            Property(p => p.Description).IsOptional();
            Property(p => p.Description).HasMaxLength(1000);

            HasRequired(p => p.Employer)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.EmployerId);
        }
    }
}
