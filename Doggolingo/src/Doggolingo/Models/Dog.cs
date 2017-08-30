using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Doggolingo.Models
{
    public class Dog
    {
        [Key]
        public int DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public int Streak { get; set; }
        public int Treats { get; set; }
        public virtual DogParent USer { get; set; }

        public DogParent FindUser(string UserName)
        {
            DogParent thisUser = new DoggolingoDbContext().DogParents.FirstOrDefault(u => u.UserName == UserName);
            return thisUser;
        }
    }
}
