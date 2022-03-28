

using Quanlicaan.Models;
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
        public ActionResult Regist()
        {
            return View("Regist");
        }

        [HttpPost]
        public ActionResult Create(NhanVien collecttion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new UserModel();
                    int res = model.Create(collecttion.HoTen,collecttion.GioiTinh,collecttion.DiaChi,collecttion.SDT,collecttion.IDPhongBan,collecttion.ChucVu,collecttion.username,collecttion.upassword,collecttion.trangthai);

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