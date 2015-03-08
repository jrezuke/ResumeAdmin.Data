using System.Linq;
using ResumeAdmin.Data.Entities;

namespace ResumeAdmin.Data
{
    public interface IResumeRepository
    {
        IQueryable<Resume> GetAllResumes();
        Resume GetResume(int resumeId);
        bool Add(Resume resume);
        bool AddorUpdate(Resume resume);
        PersonalInfo GetPersonalInfo(int personalInfoId);
        Summary GetSummary(int? summaryId);
        bool SaveAll();
    }
}
