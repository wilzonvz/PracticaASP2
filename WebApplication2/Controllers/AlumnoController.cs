using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AlumnoController : Controller
    {
        static List<Alumno> listaAlumnos = new List<Alumno>()
        {
            new Alumno(1, "Alex Marin", 1500, new System.DateTime(2002, 6, 30)),
            new Alumno(2, "Maria Flores", 1200, new System.DateTime(2000, 5, 10)),
            new Alumno(3, "Wilson Villalobos", 1450, new System.DateTime(2001, 8, 14)),
            new Alumno(4, "Bryan Sobalvarro", 1100, new System.DateTime(2001, 6, 25)),
            new Alumno(5, "José Feliciano", 1820, new System.DateTime(2000, 4, 12))

        };

        // GET: Alumno
        public ActionResult Index()
        {
            return View(listaAlumnos);
        }
    }
}
