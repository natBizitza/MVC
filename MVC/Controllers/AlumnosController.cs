using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlumnosController : Controller
    {
        public IActionResult Index()
        {
            Alumno a1 = new Alumno
            {
                Id = 1,
                Nombre="Natalia",
                Apellido="Romankevich"
            };
            return View(a1);
        }
    }
}