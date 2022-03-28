using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;

namespace Models
{
    public class UserModel
    {
        private quanlicaanDbContext context = null;
        public UserModel()
        {
            context = new quanlicaanDbContext();
        }
        public bool Login(string username, string password)
        {
            object[] sqlParams =  {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password),
            };
            var res = 
                context.Database.SqlQuery<bool>("spLogin @username,@password", sqlParams).SingleOrDefault();
            return res;
        }

        public int Create(String id, String name, String username, String passsword, String idphongban, bool? quyendangki, String idchucvu, bool? trangthai)
        {
            object[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Hoten", name),
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", passsword),
                new SqlParameter("@Idphongban", idphongban),
                new SqlParameter("@Quyendangky", quyendangki),
                new SqlParameter("@Idchucvu", idchucvu),
                new SqlParameter("@Trangthai", trangthai)
            };
            int res = context.Database.ExecuteSqlCommand("spInsertUser @Id,@Hoten,@Username,@Password,@Idphongban,@Quyendangky,@Idchucvu,@Trangthai", parameters);
            return res;
        }
    }
}
