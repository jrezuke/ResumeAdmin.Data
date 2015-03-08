using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class EducationMapper : EntityTypeConfiguration<Education>
    {
        public EducationMapper()
        {
            ToTable("Educations");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);

            Property(p => p.Address).IsOptional();
            Property(p => p.Address).HasMaxLength(100);

            Property(p => p.City).IsOptional();
            Property(p => p.City).HasMaxLength(50);

            Property(p => p.State).IsOptional();
            Property(p => p.State).HasMaxLength(10);

            Property(p => p.Degree).IsOptional();
            Property(p => p.Degree).HasMaxLength(50);

        }
    }
}
