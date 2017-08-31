using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Doggolingo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Doggolingo.Controllers
{
    public class ModulesController : Controller
    {
        private DoggolingoDbContext db = new DoggolingoDbContext();

        public IActionResult Index()
        {
            return View(db.Modules.Include(m => m.Lessons).ToList());
        }

        public IActionResult Details(int id)
        {
            Module thisModule = db.Modules.Include(m => m.Lessons)
                                          .FirstOrDefault(m => m.ModuleId == id);
            return View(thisModule);
        }

        [Authorize]
        [HttpPost]
        public IActionResult MarkComplete(int moduleId)
        {
            Module thisModule = db.Modules.FirstOrDefault(m => m.ModuleId == moduleId);
            DogParent thisDogParent = db.DogParents.FirstOrDefault(d => d.UserName == User.Identity.Name);
            thisDogParent.CompletedModules.Add(thisModule);
            db.Entry(thisDogParent).State = EntityState.Modified;
            db.SaveChanges();
            return View("Index", "Modules");
        }
    }
}
