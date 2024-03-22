using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TracNghiemOnline.Models;

public partial class TracNghiemOnlineContext : DbContext
{
    public TracNghiemOnlineContext()
    {
    }

    public TracNghiemOnlineContext(DbContextOptions<TracNghiemOnlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cauhoi> Cauhois { get; set; }

    public virtual DbSet<Dethi> Dethis { get; set; }

    public virtual DbSet<Ketqua> Ketquas { get; set; }

    public virtual DbSet<Loaitk> Loaitks { get; set; }

    public virtual DbSet<Lophoc> Lophocs { get; set; }

    public virtual DbSet<Monhoc> Monhocs { get; set; }

    public virtual DbSet<Mucdokho> Mucdokhos { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TTLA;Database=TracNghiemOnline;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cauhoi>(entity =>
        {
            entity.HasKey(e => e.Idcauhoi);

            entity.ToTable("CAUHOI");

            entity.Property(e => e.Idcauhoi)
                .ValueGeneratedNever()
                .HasColumnName("IDCAUHOI");
            entity.Property(e => e.Da)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DA");
            entity.Property(e => e.DaA)
                .HasMaxLength(50)
                .HasColumnName("DA_A");
            entity.Property(e => e.DaB)
                .HasMaxLength(50)
                .HasColumnName("DA_B");
            entity.Property(e => e.DaC)
                .HasMaxLength(50)
                .HasColumnName("DA_C");
            entity.Property(e => e.DaD)
                .HasMaxLength(50)
                .HasColumnName("DA_D");
            entity.Property(e => e.Iddokho).HasColumnName("IDDOKHO");
            entity.Property(e => e.Idmon).HasColumnName("IDMON");
            entity.Property(e => e.Imgch).HasColumnName("IMGCH");
            entity.Property(e => e.Loigiai).HasColumnName("LOIGIAI");
            entity.Property(e => e.Noidung).HasColumnName("NOIDUNG");
            entity.Property(e => e.Videoch).HasColumnName("VIDEOCH");

            entity.HasOne(d => d.IddokhoNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.Iddokho)
                .HasConstraintName("FK_CAUHOI_MUCDOKHO");

            entity.HasOne(d => d.IdmonNavigation).WithMany(p => p.Cauhois)
                .HasForeignKey(d => d.Idmon)
                .HasConstraintName("FK_CAUHOI_MONHOC");

            entity.HasMany(d => d.Iddethis).WithMany(p => p.Idcauhois)
                .UsingEntity<Dictionary<string, object>>(
                    "DethiCauhoi",
                    r => r.HasOne<Dethi>().WithMany()
                        .HasForeignKey("Iddethi")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DETHI_CAUHOI_DETHI"),
                    l => l.HasOne<Cauhoi>().WithMany()
                        .HasForeignKey("Idcauhoi")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DETHI_CAUHOI_CAUHOI"),
                    j =>
                    {
                        j.HasKey("Idcauhoi", "Iddethi");
                        j.ToTable("DETHI_CAUHOI");
                        j.IndexerProperty<long>("Idcauhoi").HasColumnName("IDCAUHOI");
                        j.IndexerProperty<int>("Iddethi").HasColumnName("IDDETHI");
                    });
        });

        modelBuilder.Entity<Dethi>(entity =>
        {
            entity.HasKey(e => e.Iddethi);

            entity.ToTable("DETHI");

            entity.Property(e => e.Iddethi).HasColumnName("IDDETHI");
            entity.Property(e => e.Ngaythi)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTHI");
            entity.Property(e => e.Slcau).HasColumnName("SLCAU");
            entity.Property(e => e.Thoigianthi).HasColumnName("THOIGIANTHI");
        });

        modelBuilder.Entity<Ketqua>(entity =>
        {
            entity.HasKey(e => new { e.Idtk, e.Iddethi, e.Idcauhoi });

            entity.ToTable("KETQUA");

            entity.Property(e => e.Idtk).HasColumnName("IDTK");
            entity.Property(e => e.Iddethi).HasColumnName("IDDETHI");
            entity.Property(e => e.Idcauhoi).HasColumnName("IDCAUHOI");
            entity.Property(e => e.Da)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("DA");

            entity.HasOne(d => d.IdcauhoiNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.Idcauhoi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KETQUA_CAUHOI");

            entity.HasOne(d => d.IddethiNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.Iddethi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KETQUA_DETHI");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.Ketquas)
                .HasForeignKey(d => d.Idtk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KETQUA_TAIKHOAN");
        });

        modelBuilder.Entity<Loaitk>(entity =>
        {
            entity.HasKey(e => e.Idloaitk);

            entity.ToTable("LOAITK");

            entity.Property(e => e.Idloaitk)
                .ValueGeneratedNever()
                .HasColumnName("IDLOAITK");
            entity.Property(e => e.Loaitk1)
                .HasMaxLength(50)
                .HasColumnName("LOAITK");
        });

        modelBuilder.Entity<Lophoc>(entity =>
        {
            entity.HasKey(e => e.Idlop);

            entity.ToTable("LOPHOC");

            entity.Property(e => e.Idlop).HasColumnName("IDLOP");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenlop)
                .HasMaxLength(50)
                .HasColumnName("TENLOP");
        });

        modelBuilder.Entity<Monhoc>(entity =>
        {
            entity.HasKey(e => e.Idmon);

            entity.ToTable("MONHOC");

            entity.Property(e => e.Idmon).HasColumnName("IDMON");
            entity.Property(e => e.Idlop).HasColumnName("IDLOP");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenmon)
                .HasMaxLength(50)
                .HasColumnName("TENMON");

            entity.HasOne(d => d.IdlopNavigation).WithMany(p => p.Monhocs)
                .HasForeignKey(d => d.Idlop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MONHOC_LOPHOC");
        });

        modelBuilder.Entity<Mucdokho>(entity =>
        {
            entity.HasKey(e => e.Iddokho);

            entity.ToTable("MUCDOKHO");

            entity.Property(e => e.Iddokho).HasColumnName("IDDOKHO");
            entity.Property(e => e.Tendk)
                .HasMaxLength(50)
                .HasColumnName("TENDK");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Idtk);

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.Idtk).HasColumnName("IDTK");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hoten)
                .HasMaxLength(250)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Idloaitk).HasColumnName("IDLOAITK");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(50)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Sdt).HasColumnName("SDT");
            entity.Property(e => e.Tentaikhoan)
                .HasMaxLength(50)
                .HasColumnName("TENTAIKHOAN");

            entity.HasOne(d => d.IdloaitkNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.Idloaitk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAIKHOAN_LOAITK");

            entity.HasMany(d => d.Iddethis).WithMany(p => p.Idtks)
                .UsingEntity<Dictionary<string, object>>(
                    "TaikhoanDethi",
                    r => r.HasOne<Dethi>().WithMany()
                        .HasForeignKey("Iddethi")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TAIKHOAN_DETHI_DETHI"),
                    l => l.HasOne<Taikhoan>().WithMany()
                        .HasForeignKey("Idtk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TAIKHOAN_DETHI_TAIKHOAN"),
                    j =>
                    {
                        j.HasKey("Idtk", "Iddethi");
                        j.ToTable("TAIKHOAN_DETHI");
                        j.IndexerProperty<int>("Idtk").HasColumnName("IDTK");
                        j.IndexerProperty<int>("Iddethi").HasColumnName("IDDETHI");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
