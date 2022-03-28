using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using Quanlicaan.Models;
using System.Linq;

namespace Quanlicaan.Controllers
{
    public class NhanVienController : Controller
    {


        public ActionResult Index()

        {

            var entities = new Model1();

            return View(entities.NhanViens.ToList());

        }
    }
}