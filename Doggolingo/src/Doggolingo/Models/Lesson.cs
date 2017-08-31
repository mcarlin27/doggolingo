using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggolingo.Models
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Module Module { get; set; }
        public ICollection <Step> Steps { get; set; }

        public Lesson()
        {
        }
    }
}
