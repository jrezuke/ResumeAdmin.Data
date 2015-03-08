namespace ResumeAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class SkillType
    {
        public SkillType()
        {
            Skills = new HashSet<Skill>();
            Resumes = new HashSet<Resume>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public ICollection<Resume> Resumes { get; set; }
    }
}
