using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class EmployerMapper: EntityTypeConfiguration<Employer>
    {
        public EmployerMapper()
        {
            ToTable("Employers");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);
            
            Property(p => p.City).IsOptional();
            Property(p => p.City).HasMaxLength(50);

            Property(p => p.State).IsOptional();
            Property(p => p.State).HasMaxLength(10);

            Property(p => p.Duration).IsOptional();
            Property(p => p.Duration).HasMaxLength(50);

            Property(p => p.Title).IsOptional();
            Property(p => p.Title).HasMaxLength(50);
        }
    }
}
