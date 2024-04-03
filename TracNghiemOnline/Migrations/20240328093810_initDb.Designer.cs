﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TracNghiemOnline.Data;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240328093810_initDb")]
    partial class initDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CauhoiDethi", b =>
                {
                    b.Property<int>("IdcauhoisId")
                        .HasColumnType("int");

                    b.Property<int>("IddethisId")
                        .HasColumnType("int");

                    b.HasKey("IdcauhoisId", "IddethisId");

                    b.HasIndex("IddethisId");

                    b.ToTable("CauhoiDethi");
                });

            modelBuilder.Entity("DethiTaikhoan", b =>
                {
                    b.Property<int>("IddethisId")
                        .HasColumnType("int");

                    b.Property<int>("IdtksId")
                        .HasColumnType("int");

                    b.HasKey("IddethisId", "IdtksId");

                    b.HasIndex("IdtksId");

                    b.ToTable("DethiTaikhoan");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Cauhoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Da")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DaD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Iddokho")
                        .HasColumnType("int");

                    b.Property<int?>("IddokhoNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("Idmon")
                        .HasColumnType("int");

                    b.Property<int?>("IdmonNavigationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imgch")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Loigiai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Noidung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Videoch")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("IddokhoNavigationId");

                    b.HasIndex("IdmonNavigationId");

                    b.ToTable("Cauhois");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Dethi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Ngaythi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Slcau")
                        .HasColumnType("int");

                    b.Property<int?>("Thoigianthi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dethis");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Ketqua", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Da")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Idcauhoi")
                        .HasColumnType("bigint");

                    b.Property<int>("IdcauhoiNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("Iddethi")
                        .HasColumnType("int");

                    b.Property<int>("IddethiNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("IdtkNavigationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdcauhoiNavigationId");

                    b.HasIndex("IddethiNavigationId");

                    b.HasIndex("IdtkNavigationId");

                    b.ToTable("Ketquas");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Loaitk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Loaitk1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Loaitks");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Lophoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenlop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lophocs");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Monhoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Idlop")
                        .HasColumnType("int");

                    b.Property<int?>("IdlopNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenmon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdlopNavigationId");

                    b.ToTable("Monhocs");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Mucdokho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tendk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mucdokhos");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Taikhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idloaitk")
                        .HasColumnType("int");

                    b.Property<int>("IdloaitkNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("Matkhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Sdt")
                        .HasColumnType("bigint");

                    b.Property<string>("Tentaikhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdloaitkNavigationId");

                    b.ToTable("Taikhoan");
                });

            modelBuilder.Entity("CauhoiDethi", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Cauhoi", null)
                        .WithMany()
                        .HasForeignKey("IdcauhoisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TracNghiemOnline.Models.Dethi", null)
                        .WithMany()
                        .HasForeignKey("IddethisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DethiTaikhoan", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Dethi", null)
                        .WithMany()
                        .HasForeignKey("IddethisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TracNghiemOnline.Models.Taikhoan", null)
                        .WithMany()
                        .HasForeignKey("IdtksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Cauhoi", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Mucdokho", "IddokhoNavigation")
                        .WithMany("Cauhois")
                        .HasForeignKey("IddokhoNavigationId");

                    b.HasOne("TracNghiemOnline.Models.Monhoc", "IdmonNavigation")
                        .WithMany("Cauhois")
                        .HasForeignKey("IdmonNavigationId");

                    b.Navigation("IddokhoNavigation");

                    b.Navigation("IdmonNavigation");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Ketqua", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Cauhoi", "IdcauhoiNavigation")
                        .WithMany("Ketquas")
                        .HasForeignKey("IdcauhoiNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TracNghiemOnline.Models.Dethi", "IddethiNavigation")
                        .WithMany("Ketquas")
                        .HasForeignKey("IddethiNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TracNghiemOnline.Models.Taikhoan", "IdtkNavigation")
                        .WithMany("Ketquas")
                        .HasForeignKey("IdtkNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdcauhoiNavigation");

                    b.Navigation("IddethiNavigation");

                    b.Navigation("IdtkNavigation");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Monhoc", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Lophoc", "IdlopNavigation")
                        .WithMany("Monhocs")
                        .HasForeignKey("IdlopNavigationId");

                    b.Navigation("IdlopNavigation");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Taikhoan", b =>
                {
                    b.HasOne("TracNghiemOnline.Models.Loaitk", "IdloaitkNavigation")
                        .WithMany("Taikhoans")
                        .HasForeignKey("IdloaitkNavigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdloaitkNavigation");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Cauhoi", b =>
                {
                    b.Navigation("Ketquas");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Dethi", b =>
                {
                    b.Navigation("Ketquas");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Loaitk", b =>
                {
                    b.Navigation("Taikhoans");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Lophoc", b =>
                {
                    b.Navigation("Monhocs");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Monhoc", b =>
                {
                    b.Navigation("Cauhois");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Mucdokho", b =>
                {
                    b.Navigation("Cauhois");
                });

            modelBuilder.Entity("TracNghiemOnline.Models.Taikhoan", b =>
                {
                    b.Navigation("Ketquas");
                });
#pragma warning restore 612, 618
        }
    }
}