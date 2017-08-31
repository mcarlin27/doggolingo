using System.ComponentModel.DataAnnotations;

namespace Doggolingo.Models
{
    public class Step
    {
        [Key]
        public int StepId { get; set; }
        public string Description { get; set; }
        public virtual Lesson Lesson { get; set; }

        public Step()
        {
        }
    }
}
