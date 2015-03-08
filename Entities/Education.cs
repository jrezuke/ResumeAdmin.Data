using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ResumeAdmin.Data.Entities
{
    public class Education
    {
        public Education()
        {
            Resumes = new List<Resume>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Degree { get; set; }

        public ICollection<Resume> Resumes { get; set; }
    }
}
