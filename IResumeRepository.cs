using System.Linq;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data
{
    public interface IResumeRepository
    {
        IQueryable<Resume> GetAllResumes();
        IQueryable<ResumeShort> GetAllResumesShort();
        Resume GetResume(int resumeId);
        bool Add(Resume resume);
        bool AddorUpdate(Resume resume);
        IQueryable<PersonalInfoShort> GetAllPersonalInfoShort();
        PersonalInfo GetPersonalInfo(int personalInfoId);
        Summary GetSummary(int? summaryId);
        bool SaveAll();
    }
}
