using System;
using System.Data.Entity;
using System.Linq;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data
{
    public class ResumeRepository:IResumeRepository
    {
        private readonly ResumeDbContext _dbContext;

        public ResumeRepository(ResumeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Resume> GetAllResumes()
        {
            return _dbContext.Resumes.AsQueryable();
        }

        public Resume GetResume(int resumeId)
        {
            return _dbContext.Resumes.Find(resumeId);
        }

        public bool Add(Resume resume)
        {
            try
            {
                _dbContext.Resumes.Add(resume);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddorUpdate(Resume resume)
        {
            try
            {
                if (resume.Id == default(int))
                {
                    var entity = _dbContext.Entry(resume);
                    entity.State = EntityState.Added;
                }
                else
                {
                    
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public PersonalInfo GetPersonalInfo(int personalInfoId)
        {
            return _dbContext.PersonalInfo.Find(personalInfoId);
        }

        public Summary GetSummary(int? summaryId)
        {
            if (summaryId == null)
                return null;
            return _dbContext.Summaries.Find(summaryId);
        }
        public bool SaveAll()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
