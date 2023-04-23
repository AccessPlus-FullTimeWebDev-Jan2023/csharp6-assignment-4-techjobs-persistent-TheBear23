using System.ComponentModel.DataAnnotations.Schema;

namespace TechJobs6Persistent.Models
{
    [Table("job_skills")]
    public class JobSkill
    {
        public int Id { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }
        public virtual Job Job { get; set; }

        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }

        public JobSkill() { }

        public JobSkill(Job job, Skill skill)
        {
            Job = job;
            Skill = skill;
        }
    }
}
