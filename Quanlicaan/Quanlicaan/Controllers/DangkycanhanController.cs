using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quanlicaan.Controllers
{
    public class DangkycanhanController : Controller
    {
        // GET: Dangkycanhan
        public ActionResult Index()
        {
            return View("dangkyancanhan");
        }
    }
}