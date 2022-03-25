using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class quanlicaanDbContext : DbContext
    {
        public quanlicaanDbContext()
            : base("name=quanlicaanDbContext")
        {
        }

        public virtual DbSet<tblCaAn> tblCaAns { get; set; }
        public virtual DbSet<tblChiTietSuatAn> tblChiTietSuatAns { get; set; }
        public virtual DbSet<tblChucVu> tblChucVus { get; set; }
        public virtual DbSet<tblNguoiDung> tblNguoiDungs { get; set; }
        public virtual DbSet<tblPhongBan> tblPhongBans { get; set; }
        public virtual DbSet<tblSuatAn> tblSuatAns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCaAn>()
                .HasMany(e => e.tblChiTietSuatAns)
                .WithRequired(e => e.tblCaAn)
                .HasForeignKey(e => e.idcaan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblChiTietSuatAn>()
                .Property(e => e.idnguoian)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblChucVu>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblChucVu>()
                .HasMany(e => e.tblNguoiDungs)
                .WithRequired(e => e.tblChucVu)
                .HasForeignKey(e => e.idchucvu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNguoiDung>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoiDung>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoiDung>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoiDung>()
                .Property(e => e.idphongban)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoiDung>()
                .Property(e => e.idchucvu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblNguoiDung>()
                .HasMany(e => e.tblChiTietSuatAns)
                .WithRequired(e => e.tblNguoiDung)
                .HasForeignKey(e => e.idnguoian)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNguoiDung>()
                .HasMany(e => e.tblSuatAns)
                .WithRequired(e => e.tblNguoiDung)
                .HasForeignKey(e => e.idnguoidung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPhongBan>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblPhongBan>()
                .HasMany(e => e.tblNguoiDungs)
                .WithRequired(e => e.tblPhongBan)
                .HasForeignKey(e => e.idphongban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSuatAn>()
                .Property(e => e.idnguoidung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblSuatAn>()
                .HasMany(e => e.tblChiTietSuatAns)
                .WithRequired(e => e.tblSuatAn)
                .HasForeignKey(e => e.idsuatan)
                .WillCascadeOnDelete(false);
        }
    }
}
