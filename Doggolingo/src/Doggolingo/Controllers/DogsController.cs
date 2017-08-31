using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Doggolingo.Models;
using System.Linq;

namespace Doggolingo.Controllers
{
    public class DogsController : Controller
    {
        private DoggolingoDbContext db = new DoggolingoDbContext();

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Dog dog)
        {
            dog.DogParent = db.DogParents.FirstOrDefault(db => db.UserName == User.Identity.Name);
            db.Dogs.Add(dog);
            db.SaveChanges();
            return RedirectToAction("Index", "DogParents");
        }
    }
}
