using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Motel_Managerment_API.Models
{
    public partial class DBNhaTroContext : DbContext
    {
        public DBNhaTroContext()
        {
        }

        public DBNhaTroContext(DbContextOptions<DBNhaTroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chunha> Chunhas { get; set; } = null!;
        public virtual DbSet<Cthoadon> Cthoadons { get; set; } = null!;
        public virtual DbSet<Dichvu> Dichvus { get; set; } = null!;
        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Hopdong> Hopdongs { get; set; } = null!;
        public virtual DbSet<Khachthue> Khachthues { get; set; } = null!;
        public virtual DbSet<Phongtro> Phongtros { get; set; } = null!;
        public virtual DbSet<Thanhtoan> Thanhtoans { get; set; } = null!;
        public virtual DbSet<Tinhtrang> Tinhtrangs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =DULCIEPOTATO; database = DBNhaTro; uid=sa; pwd=123456; TrustServerCertificate = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chunha>(entity =>
            {
                entity.HasKey(e => e.Idcn);

                entity.ToTable("CHUNHA");

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<Cthoadon>(entity =>
            {
                entity.HasKey(e => new { e.Idhd, e.MaDv });

                entity.ToTable("CTHOADON");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.HasOne(d => d.IdhdNavigation)
                    .WithMany(p => p.Cthoadons)
                    .HasForeignKey(d => d.Idhd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHOADON_HOADON");

                entity.HasOne(d => d.MaDvNavigation)
                    .WithMany(p => p.Cthoadons)
                    .HasForeignKey(d => d.MaDv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHOADON_DICHVU");
            });

            modelBuilder.Entity<Dichvu>(entity =>
            {
                entity.HasKey(e => e.MaDv);

                entity.ToTable("DICHVU");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenDv)
                    .HasMaxLength(50)
                    .HasColumnName("TenDV");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Idhd);

                entity.ToTable("HOADON");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.Idtt).HasColumnName("IDTT");

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.SoHopDong).HasMaxLength(50);

                entity.HasOne(d => d.IdttNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Idtt)
                    .HasConstraintName("FK_HOADON_THANHTOAN");
            });

            modelBuilder.Entity<Hopdong>(entity =>
            {
                entity.HasKey(e => e.SoHopDong);

                entity.ToTable("HOPDONG");

                entity.Property(e => e.SoHopDong).HasMaxLength(50);

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DuKienTra).HasColumnType("date");

                entity.Property(e => e.Idcn).HasColumnName("IDCN");

                entity.Property(e => e.MaPhong).HasMaxLength(50);

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.Property(e => e.TuNgay).HasColumnType("date");

                entity.HasOne(d => d.CccdNavigation)
                    .WithMany(p => p.Hopdongs)
                    .HasForeignKey(d => d.Cccd)
                    .HasConstraintName("FK_HOPDONG_KHACHTHUE");

                entity.HasOne(d => d.IdcnNavigation)
                    .WithMany(p => p.Hopdongs)
                    .HasForeignKey(d => d.Idcn)
                    .HasConstraintName("FK_HOPDONG_CHUNHA");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.Hopdongs)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK_HOPDONG_PHONGTRO");
            });

            modelBuilder.Entity<Khachthue>(entity =>
            {
                entity.HasKey(e => e.Cccd);

                entity.ToTable("KHACHTHUE");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.QueQuan).HasMaxLength(500);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.ThongTinKhac).HasMaxLength(500);
            });

            modelBuilder.Entity<Phongtro>(entity =>
            {
                entity.HasKey(e => e.MaPhong);

                entity.ToTable("PHONGTRO");

                entity.Property(e => e.MaPhong).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.ThongTin).HasMaxLength(500);

                entity.HasOne(d => d.MaTinhTrangNavigation)
                    .WithMany(p => p.Phongtros)
                    .HasForeignKey(d => d.MaTinhTrang)
                    .HasConstraintName("FK_PHONGTRO_TINHTRANG");
            });

            modelBuilder.Entity<Thanhtoan>(entity =>
            {
                entity.HasKey(e => e.Idtt);

                entity.ToTable("THANHTOAN");

                entity.Property(e => e.Idtt).HasColumnName("IDTT");

                entity.Property(e => e.LoaiThanhToan).HasMaxLength(500);
            });

            modelBuilder.Entity<Tinhtrang>(entity =>
            {
                entity.HasKey(e => e.MaTinhTrang);

                entity.ToTable("TINHTRANG");

                entity.Property(e => e.TinhTrang1)
                    .HasMaxLength(50)
                    .HasColumnName("TinhTrang");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("USER");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Role).HasColumnName("ROLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
