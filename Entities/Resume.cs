using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeAdmin.Data.Entities
{
    public class Resume
    {
        public Resume()
        {
            PersonalInfo = new PersonalInfo();
            Summary = new Summary();
            SkillTypes = new List<SkillType>();
            Employers = new List<Employer>();
            Educations = new List<Education>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PersonalInfoId { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public int? SummaryId { get; set; }
        public  Summary Summary { get; set; }
        public ICollection<SkillType> SkillTypes { get; set; }
        public ICollection<Employer> Employers { get; set; }
        public ICollection<Education> Educations { get; set; }
        


    }
}
