using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Doggolingo.Models;

namespace Doggolingo.Controllers
{
    public class DogParentsController : Controller
    {
        private DoggolingoDbContext db = new DoggolingoDbContext();

        public IActionResult Index()
        {
            return View();
        }
    }
}
