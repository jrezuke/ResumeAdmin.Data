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

        public IQueryable<ResumeShort> GetAllResumesShort()
        {
            return
                _dbContext.Resumes.Select(
                    r =>
                        new ResumeShort
                        {
                            Id = r.Id,
                            Name = r.Name,
                            Description = r.Description,
                            PersonalInfoId = r.PersonalInfoId
                        });
        }
        public IQueryable<PersonalInfoShort> GetAllPersonalInfoShort()
        {
            return _dbContext.PersonalInfo.Select(
                p => new PersonalInfoShort
                {
                    Id=p.Id,
                    Name = p.Name,
                    Address1 = p.Address1,
                    Address2 = p.Address2,
                    City = p.City,
                    Email = p.Email,
                    HomePhone = p.HomePhone,
                    MobilePhone = p.MobilePhone,
                    State = p.State,
                    Zip = p.Zip
                });
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
            if (personalInfoId == 0)
                return null;
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
