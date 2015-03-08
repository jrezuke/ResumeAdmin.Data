using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data.Mappers
{
    public class SummaryMapper : EntityTypeConfiguration<Summary>
    {
        public SummaryMapper()
        {
            ToTable("Summaries");

            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).IsRequired();

            Property(p => p.Name).IsOptional();
            Property(p => p.Name).HasMaxLength(100);

            Property(p => p.Description).IsOptional();
            Property(p => p.Description).HasMaxLength(1000);

            HasMany(s => s.Resumes)
                .WithOptional(r => r.Summary)
                .HasForeignKey(r=>r.SummaryId);

        }
    }
}
