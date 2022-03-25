using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace Quanlicaan.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien

        private List<NhanVien> nhanvien = new List<NhanVien>();

        SqlCommand com = new SqlCommand();

        SqlConnection con = new SqlConnection();
        SqlDataReader dr;

        public ActionResult Index()
        {
            FetchData();
            return View();
        }
        private readonly ILogger<NhanVienController> _logger;

        public NhanVienController(ILogger<NhanVienController> logger)
        {
            _logger = logger;
            con.ConnectionString = Quanlicaan.Properties.Resource1.connectionString;
        }
      
        
        private void FetchData()
        {
            if(nhanvien.Count > 0)
            {
                nhanvien.Clear();
            }
            try
            {
                con.Open();
                com.CommandText = "SELECT TOP (1000) [ID],[HoTen],[GioiTinh],[DiaChi],[SDT],[IDPhongBan],[ChucVu],[username],[upassword],[trangthai] FROM[QuanLiCaAn].[dbo].[NhanVien] ";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    nhanvien.Add(new NhanVien() {ID=int.Parse(dr["[ID]"].ToString()),HoTen=dr["[HoTen]"].ToString(), GioiTinh = bool.Parse(dr["[GioiTinh]"].ToString()), DiaChi = dr["[DiaChi]"].ToString(), SDT = dr["[SDT]"].ToString(), IDPhongBan = int.Parse(dr["[IDPhongBan]"].ToString()), username = dr["[username]"].ToString(), upassword = dr["[upassword]"].ToString(), trangthai = bool.Parse(dr["[trangthai]"].ToString() )});
                }

                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}