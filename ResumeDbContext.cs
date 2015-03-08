using System.Data.Entity;
using ResumeAdmin.Data.Entities;
using ResumeAdmin.Data.Mappers;

namespace ResumeAdmin.Data
{
    public class ResumeDbContext:DbContext
    {
        public ResumeDbContext(): base("name=Resume")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ResumeDbContext, ResumeMigrationsConfiguration>());
            
        }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<ProjectDetail> ProjectDetails { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<Summary> Summaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ResumeMapper());
            modelBuilder.Configurations.Add(new PersonalInfoMapper());
            modelBuilder.Configurations.Add(new SummaryMapper());
            modelBuilder.Configurations.Add(new EducationMapper());
            modelBuilder.Configurations.Add(new EmployerMapper());
            modelBuilder.Configurations.Add(new SkillTypeMapper());
            modelBuilder.Configurations.Add(new SkillMapper());
            modelBuilder.Configurations.Add(new ProjectMapper());
            modelBuilder.Configurations.Add(new ProjectDetailMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}
