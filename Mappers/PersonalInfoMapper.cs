using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class PersonalInfoMapper:EntityTypeConfiguration<PersonalInfo>
    {
        public PersonalInfoMapper()
        {
            ToTable("PersonalInfo");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);

            Property(p => p.Address1).IsOptional();
            Property(p => p.Address1).HasMaxLength(100);

            Property(p => p.Address2).IsOptional();
            Property(p => p.Address2).HasMaxLength(100);

            Property(p => p.City).IsOptional();
            Property(p => p.City).HasMaxLength(50);

            Property(p => p.State).IsOptional();
            Property(p => p.State).HasMaxLength(10);

            Property(p => p.Zip).IsOptional();
            Property(p => p.Zip).HasMaxLength(10);

            Property(p => p.HomePhone).IsOptional();
            Property(p => p.HomePhone).HasMaxLength(20);

            Property(p => p.MobilePhone).IsOptional();
            Property(p => p.MobilePhone).HasMaxLength(20);

            Property(p => p.Email).IsOptional();
            Property(p => p.Email).HasMaxLength(100);

            HasMany(p => p.Resumes)
                .WithRequired(r => r.PersonalInfo)
                .HasForeignKey(r=>r.PersonalInfoId);
        }
    }
}
