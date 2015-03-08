using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ResumeAdmin.Data.Entities
{
    public class Project
    {
        public Project()
        {
            ProjectDetails = new HashSet<ProjectDetail>();
            Employer = new Employer();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public int EmployerId { get; set; }
        public ICollection<ProjectDetail> ProjectDetails { get; set; }
        public Employer Employer { get; set; }
    }
}
