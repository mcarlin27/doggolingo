using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggolingo.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public int Difficulty { get; set; }
        public int Treats { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }

        public Module()
        {
            Treats = 10;
        }
    }
}
