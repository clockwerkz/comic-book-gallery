using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "<h1>This is the Home Page.</h1>";
        }
    }
}