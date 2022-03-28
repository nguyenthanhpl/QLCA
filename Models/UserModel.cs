using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel
    {
        private QlcaDbContext db = null;
        public UserModel()
        {
            db = new QlcaDbContext();
        }

        public bool Login(string username, string password)
        {
            object[] sql =
            {
                new SqlParameter("@userName", username),
                new SqlParameter("@password", password),
            };
            var result = db.Database.SqlQuery<bool>("NhanVien_Login @userName,@password", sql).SingleOrDefault();
            return result;
        }

        public int Create(String id, String HoTen, bool? GioiTinh, string DiaChi, string SDT, String idphongban, String username, String passsword, bool? TrangThai, String ChucVu)
        {
            object[] parameters =
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Hoten", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@IdPb", idphongban),
                new SqlParameter("@username", username),
                new SqlParameter("@pass", passsword),
                new SqlParameter("@Trangthai", TrangThai),
                new SqlParameter("@ChucVu", ChucVu),

            };
            int res = db.Database.ExecuteSqlCommand("Sp_NhanVien_Insert @ID,@Hoten,@GioiTinh,@DiaChi,@SDT,@IdPb,@username,@pass,@Trangthai,@ChucVu", parameters);
            return res;
        }

    }
}
