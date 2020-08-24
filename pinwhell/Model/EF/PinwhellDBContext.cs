namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PinwhellDbContext : DbContext
    {
        public PinwhellDbContext()
            : base("name=PinwhellDbContext")
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Detail_BLog> Detail_BLog { get; set; }
        public virtual DbSet<Detail_Thongbao> Detail_Thongbao { get; set; }
        public virtual DbSet<HocPhi> HocPhi { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TaiLieuHocTap> TaiLieuHocTap { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<ThongBao> ThongBao { get; set; }
        public virtual DbSet<TinhTrangHocPhi> TinhTrangHocPhi { get; set; }
        public virtual DbSet<TinhTrangHocTap> TinhTrangHocTap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail_BLog>()
                .HasMany(e => e.Blog)
                .WithOptional(e => e.Detail_BLog)
                .HasForeignKey(e => e.ChiTietBlog);

            modelBuilder.Entity<Detail_Thongbao>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Detail_Thongbao>()
                .HasMany(e => e.ThongBao)
                .WithOptional(e => e.Detail_Thongbao)
                .HasForeignKey(e => e.Chitietthongbao);

            modelBuilder.Entity<HocPhi>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.HocPhi1)
                .HasForeignKey(e => e.HocPhi);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.MonHoc1)
                .HasForeignKey(e => e.MonHoc);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.TaiLieuHocTap)
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
                .Property(e => e.Quyen)
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

            modelBuilder.Entity<ThongBao>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangHocPhi>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangHocPhi>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.TinhTrangHocPhi)
                .HasForeignKey(e => e.TinhTrangHP);

            modelBuilder.Entity<TinhTrangHocTap>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.TinhTrangHocTap)
                .HasForeignKey(e => e.TinhTrangHT);
        }
    }
}
