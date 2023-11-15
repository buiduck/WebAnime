using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAnime.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Blogs()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }

}