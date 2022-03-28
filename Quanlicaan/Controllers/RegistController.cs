using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quanlicaan.Controllers
{
    public class RegistController : Controller
    {
        // GET: Regist
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblNguoiDung collecttion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new UserModel();
                    int res = model.Create(collecttion.id, collecttion.hoten, collecttion.username,
                        collecttion.password, collecttion.idphongban, collecttion.quyendangky,
                        collecttion.idchucvu, collecttion.trangthai);

                    if(res > 0)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }
                    
                }
                return View(collecttion);
            
            }
            catch
            {
                return View();
            }
        }
        
    }
}