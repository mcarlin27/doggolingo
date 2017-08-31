using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
