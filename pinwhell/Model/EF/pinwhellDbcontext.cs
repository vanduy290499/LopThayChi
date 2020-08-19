namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class pinwhellDbcontext : DbContext
    {
        public pinwhellDbcontext()
            : base("name=pinwhellDbcontext")
        {
        }

        public virtual DbSet<HocPhi> HocPhis { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TaiLieuHocTap> TaiLieuHocTaps { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }
        public virtual DbSet<TinhTrangHocPhi> TinhTrangHocPhis { get; set; }
        public virtual DbSet<TinhTrangHocTap> TinhTrangHocTaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocPhi>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.HocPhi1)
                .HasForeignKey(e => e.HocPhi);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.MonHoc1)
                .HasForeignKey(e => e.MonHoc);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.TaiLieuHocTaps)
                .WithOptional(e => e.MonHoc1)
                .HasForeignKey(e => e.MonHoc);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Fb)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangHocPhi>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangHocPhi>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.TinhTrangHocPhi)
                .HasForeignKey(e => e.TinhTrangHP);

            modelBuilder.Entity<TinhTrangHocTap>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.TinhTrangHocTap)
                .HasForeignKey(e => e.TinhTrangHT);
        }
    }
}
