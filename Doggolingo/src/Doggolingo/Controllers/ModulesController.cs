using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Doggolingo.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
