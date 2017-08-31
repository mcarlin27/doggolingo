using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Doggolingo.Models;
using Microsoft.EntityFrameworkCore;

namespace Doggolingo.Controllers
{
    public class LessonsController : Controller
    {
        private DoggolingoDbContext db = new DoggolingoDbContext();

        public IActionResult Details(int id)
        {
            Lesson thisLesson = db.Lessons.Include(l => l.Module)
                                          .Include(l => l.Steps)
                                          .FirstOrDefault(l => l.LessonId == id);
            return View(thisLesson);
        }
    }
}
