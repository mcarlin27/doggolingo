using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggolingo.Models
{
    public class DogParent
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Streak { get; set; }
        public int Treats { get; set; }
        public string UserName { get; set; } //from Identity.User
        public virtual ICollection<Dog> Dogs { get; set; }
        public virtual ICollection<Module> CompletedModules { get; set; }

        public DogParent()
        {
            Streak = 0;
            Treats = 0;
        }
    }
}
