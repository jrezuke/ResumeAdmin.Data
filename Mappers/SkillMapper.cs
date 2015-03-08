using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class SkillMapper : EntityTypeConfiguration<Skill>
    {
        public SkillMapper()
        {
            ToTable("Skills");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);

            Property(p => p.SkillTypeId).IsRequired();

            HasRequired(p => p.SkillType)
                .WithMany(p => p.Skills)
                .HasForeignKey(p => p.SkillTypeId);
        }
    }
}
