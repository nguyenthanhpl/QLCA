using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quanlicaan.Models
{
    public class UserModel
    {

        private Model1 context = null;
        public UserModel()
        {
            context = new Model1();
        }
        public bool Login(string username, string passwords)
        {
            object[] sqlParams =  {
                new SqlParameter("@username",username),
                new SqlParameter("@upassword", passwords),
            };
            const string Sql = "spLogin @username,@upassword";
            var res =
                context.Database.SqlQuery<bool>(Sql, sqlParams).SingleOrDefault<>();
            return res;
        }



        public int Create(String name, bool Gioitinh, String Diachi, String SDT, int IDPhongBan, String ChucVu, String username, String passsword, bool? trangthai)
        {
            object[] parameters =
            {
                new SqlParameter("@Hoten", name),
                new SqlParameter("@Gioitinh", Gioitinh),
                new SqlParameter("@Diachi", Diachi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@IDPhongBan", Diachi),
                new SqlParameter("@ChucVu", Diachi),
              
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", passsword),
               
                new SqlParameter("@Trangthai", trangthai)
            };
            int res = context.Database.ExecuteSqlCommand("spInsertUser @HoTen, @GioiTinh,	@DiaChi  ,	@SDT,	@IDPhongBan ,	@ChucVu ,	@username,	@upassword ,	@trangthai )", parameters);
            return res;

        }
    }
}