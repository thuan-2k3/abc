using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_5.Controllers
{
    public class CinemaController : Controller
    {
        // GET: Cinema
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListMovies()
        {
            string connectString = ConfigurationManager.ConnectionStrings["connectsql"].ConnectionString;
            CinemaDBDataContext db  = new CinemaDBDataContext(connectString);
            var movies = db.CinemaMovies.ToList();
            return Json(movies, JsonRequestBehavior.AllowGet);
        }
    }
}
