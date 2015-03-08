using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ResumeAdmin.Data.Entities
{
    public class Employer
    {
        public Employer()
        {
            Resumes = new HashSet<Resume>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Duration { get; set; }

        public string Title { get; set; }

        public ICollection<Resume> Resumes { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
