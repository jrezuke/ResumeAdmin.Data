using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ResumeAdmin.Data.Entities
{
    public class PersonalInfo
    {
        public PersonalInfo()
        {
            Resumes = new List<Resume>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Address1 { get; set; }

        public string Address2 { get; set; }
        
        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public ICollection<Resume> Resumes { get; set; }
    }
}
