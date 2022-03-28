using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class QlcaDbContext : DbContext
    {
        public QlcaDbContext()
            : base("name=QlcaDbContext")
        {
        }

        public virtual DbSet<CaAn> CaAns { get; set; }
        public virtual DbSet<ChiTietSuatAn> ChiTietSuatAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<SuatAn> SuatAns { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaAn>()
                .HasMany(e => e.ChiTietSuatAns)
                .WithRequired(e => e.CaAn)
                .HasForeignKey(e => e.IDCaan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietSuatAn>()
                .Property(e => e.IDUser)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.IDPhongBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.upassword)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChiTietSuatAns)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.IDUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Roles)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.IDUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.SuatAns)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.IDUser);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.TaiKhoan)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<PhongBan>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.PhongBan)
                .HasForeignKey(e => e.IDPhongBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SuatAn>()
                .Property(e => e.IDUser)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SuatAn>()
                .HasMany(e => e.ChiTietSuatAns)
                .WithOptional(e => e.SuatAn)
                .HasForeignKey(e => e.IDSuatAn);

            modelBuilder.Entity<Role>()
                .Property(e => e.IDUser)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
