
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien nhanvien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new UserModel();
                    int res = model.Create(
                        nhanvien.ID,
                        nhanvien.HoTen,
                        nhanvien.GioiTinh,
                        nhanvien.DiaChi,
                        nhanvien.SDT,
                        nhanvien.IDPhongBan,
                        nhanvien.username,
                        nhanvien.upassword,
                        nhanvien.trangthai,
                        nhanvien.ChucVu
                        );

                    if (res > 0)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }

                }
                return View(nhanvien);

            }
            catch
            {
                return View();
            }
        }
        
    }
}