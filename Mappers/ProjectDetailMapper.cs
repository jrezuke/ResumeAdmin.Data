using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class ProjectDetailMapper : EntityTypeConfiguration<ProjectDetail>
    {
        public ProjectDetailMapper()
        {
            ToTable("ProjectDetails");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();
            
            Property(p => p.Description).IsOptional();
            Property(p => p.Description).HasMaxLength(1000);

            Property(p => p.ProjectId).IsRequired();

            HasRequired(p => p.Project)
                .WithMany(p=>p.ProjectDetails)
                .HasForeignKey(p=>p.ProjectId);
        }
    }
}
