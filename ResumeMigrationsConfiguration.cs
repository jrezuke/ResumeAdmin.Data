using System.Data.Entity.Migrations;

namespace ResumeAdmin.Data
{
    public class ResumeMigrationsConfiguration:DbMigrationsConfiguration<ResumeDbContext>
    {
        public ResumeMigrationsConfiguration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ResumeDbContext context)
        {
//            base.Seed(context);
//#if DEBUG
//            if (!context.Simples.Any())
//            {

//            }
//#endif
        }
    }
}
