using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ResumeAdmin.Data.Entities
{

    public class ProjectDetail
    {
        public ProjectDetail()
        {
            Project = new Project();
        }
        public int Id { get; set; }

        public string Description { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
