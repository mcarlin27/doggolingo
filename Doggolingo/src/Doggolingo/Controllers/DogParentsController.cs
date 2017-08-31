using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Doggolingo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Doggolingo.Controllers
{
    public class DogParentsController : Controller
    {
        private DoggolingoDbContext db = new DoggolingoDbContext();

        public IActionResult Index()
        {
            DogParent thisDogParent = db.DogParents.Include(db => db.Dogs)
                                                   .FirstOrDefault(db => db.UserName == User.Identity.Name);
            if (thisDogParent != null)
            {
                return View(thisDogParent);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DogParent dogParent)
        {
            dogParent.UserName = User.Identity.Name;
            db.DogParents.Add(dogParent);
            db.SaveChanges();
            if (dogParent.Dogs.Count == 0)
            {
                return RedirectToAction("Create", "Dogs");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
