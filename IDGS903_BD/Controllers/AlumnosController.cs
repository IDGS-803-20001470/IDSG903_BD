using IDGS903_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_BD.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (AlumnosDbContext dbAlumnos = new AlumnosDbContext())
            {
                return View(dbAlumnos.Alumnos.ToList());

            }
              
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            using (AlumnosDbContext dbAlumnos = new AlumnosDbContext())
            {
                dbAlumnos.Alumnos.Add(alum);
                dbAlumnos.SaveChanges();
                

            }
            return RedirectToAction("Index");

        }
    }
}