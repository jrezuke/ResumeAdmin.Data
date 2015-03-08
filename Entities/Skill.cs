namespace ResumeAdmin.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SkillTypeId { get; set; }

        public virtual SkillType SkillType { get; set; }
    }
}
