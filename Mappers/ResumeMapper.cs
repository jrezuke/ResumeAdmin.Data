using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class ResumeMapper : EntityTypeConfiguration<Resume>
    {
        public ResumeMapper()
        {
            ToTable("Resumes");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);

            Property(p => p.Description).IsOptional();
            Property(p => p.Description).HasMaxLength(1000);

            Property(p => p.PersonalInfoId).IsRequired();

            Property(p => p.SummaryId).IsOptional();

            HasMany(e => e.Educations)
                .WithMany(r => r.Resumes)
                .Map(r =>
                {
                    r.ToTable("ResumeEducation");
                    r.MapLeftKey("ResumeId");
                    r.MapRightKey("EducationId");
                });

            HasMany(e => e.Employers)
                .WithMany(r => r.Resumes)
                .Map(r =>
                {
                    r.ToTable("ResumeEmployer");
                    r.MapLeftKey("ResumeId");
                    r.MapRightKey("EmployerId");
                });

            HasMany(s => s.SkillTypes)
                .WithMany(r => r.Resumes)
                .Map(r =>
                {
                    r.ToTable("ResumeSkillType");
                    r.MapLeftKey("ResumeId");
                    r.MapRightKey("SkillTypeId");
                });
        }
    }
}
