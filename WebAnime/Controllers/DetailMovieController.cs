using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAnime.Controllers
{
    public class DetailMovieController : Controller
    {
        // GET: DetailMovie
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Watch()
        {
            return View();
        }
    }
}