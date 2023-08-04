﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TT.Data;

#nullable disable

namespace TT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230721050729_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TT.Entities.Chuas", b =>
                {
                    b.Property<int>("chuaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("capnhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayThanhLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenChua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trutri")
                        .HasColumnType("int");

                    b.HasKey("chuaId");

                    b.ToTable("chuas");
                });

            modelBuilder.Entity("TT.Entities.Daotrangs", b =>
                {
                    b.Property<int>("daotrangId")
                        .HasColumnType("int");

                    b.Property<int>("daKetThuc")
                        .HasColumnType("int");

                    b.Property<int>("nguoiTruTri")
                        .HasColumnType("int");

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noiToChuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phatTuId")
                        .HasColumnType("int");

                    b.Property<int>("soThanhVienThamGia")
                        .HasColumnType("int");

                    b.Property<DateTime>("thoiGianToChuc")
                        .HasColumnType("datetime2");

                    b.HasKey("daotrangId");

                    b.HasIndex("phatTuId");

                    b.ToTable("daotrangs");
                });

            modelBuilder.Entity("TT.Entities.Dondangkis", b =>
                {
                    b.Property<int>("dondangkiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dondangkiId"), 1L, 1);

                    b.Property<int>("daotrangId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayGuiDon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayXuLy")
                        .HasColumnType("datetime2");

                    b.Property<int>("phattuId")
                        .HasColumnType("int");

                    b.Property<int>("trangThaiDon")
                        .HasColumnType("int");

                    b.HasKey("dondangkiId");

                    b.HasIndex("daotrangId");

                    b.HasIndex("phattuId");

                    b.ToTable("dondangkis");
                });

            modelBuilder.Entity("TT.Entities.Kieuthanhviens", b =>
                {
                    b.Property<int>("kieuthanhvienId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenKieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kieuthanhvienId");

                    b.ToTable("Kieuthanhviens");
                });

            modelBuilder.Entity("TT.Entities.Phattu", b =>
                {
                    b.Property<int>("phatTuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("phatTuId"), 1L, 1);

                    b.Property<string>("anhChup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("chuaId")
                        .HasColumnType("int");

                    b.Property<int?>("daHoanTuc")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<int>("kieuthanhvienId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayHoanTuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayXuatGia")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phapDanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenDem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("phatTuId");

                    b.HasIndex("chuaId");

                    b.HasIndex("kieuthanhvienId");

                    b.ToTable("phattus");
                });

            modelBuilder.Entity("TT.Entities.Phattudaotrangs", b =>
                {
                    b.Property<int>("phattudaotrangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("phattudaotrangId"), 1L, 1);

                    b.Property<int>("daThamGia")
                        .HasColumnType("int");

                    b.Property<int>("daotrangId")
                        .HasColumnType("int");

                    b.Property<string>("lyDoKhongThamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phattuId")
                        .HasColumnType("int");

                    b.HasKey("phattudaotrangId");

                    b.HasIndex("daotrangId");

                    b.HasIndex("phattuId");

                    b.ToTable("phattudaotrangs");
                });

            modelBuilder.Entity("TT.Entities.Token", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("expired")
                        .HasColumnType("int");

                    b.Property<int>("phattuId")
                        .HasColumnType("int");

                    b.Property<int?>("revoked")
                        .HasColumnType("int");

                    b.Property<string>("stoken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("phattuId");

                    b.ToTable("tokens");
                });

            modelBuilder.Entity("TT.Entities.Daotrangs", b =>
                {
                    b.HasOne("TT.Entities.Phattu", null)
                        .WithMany("daotrangs")
                        .HasForeignKey("phatTuId");
                });

            modelBuilder.Entity("TT.Entities.Dondangkis", b =>
                {
                    b.HasOne("TT.Entities.Daotrangs", "daotrang")
                        .WithMany("dondangkis")
                        .HasForeignKey("daotrangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TT.Entities.Phattu", "phattu")
                        .WithMany()
                        .HasForeignKey("phattuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daotrang");

                    b.Navigation("phattu");
                });

            modelBuilder.Entity("TT.Entities.Phattu", b =>
                {
                    b.HasOne("TT.Entities.Chuas", "chua")
                        .WithMany("phattus")
                        .HasForeignKey("chuaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TT.Entities.Kieuthanhviens", "kieuthanhvien")
                        .WithMany("phattus")
                        .HasForeignKey("kieuthanhvienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chua");

                    b.Navigation("kieuthanhvien");
                });

            modelBuilder.Entity("TT.Entities.Phattudaotrangs", b =>
                {
                    b.HasOne("TT.Entities.Daotrangs", "daotrang")
                        .WithMany("phattudaotrangs")
                        .HasForeignKey("daotrangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TT.Entities.Phattu", "phattu")
                        .WithMany("phattudaotrangs")
                        .HasForeignKey("phattuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daotrang");

                    b.Navigation("phattu");
                });

            modelBuilder.Entity("TT.Entities.Token", b =>
                {
                    b.HasOne("TT.Entities.Phattu", "phattu")
                        .WithMany("tokens")
                        .HasForeignKey("phattuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("phattu");
                });

            modelBuilder.Entity("TT.Entities.Chuas", b =>
                {
                    b.Navigation("phattus");
                });

            modelBuilder.Entity("TT.Entities.Daotrangs", b =>
                {
                    b.Navigation("dondangkis");

                    b.Navigation("phattudaotrangs");
                });

            modelBuilder.Entity("TT.Entities.Kieuthanhviens", b =>
                {
                    b.Navigation("phattus");
                });

            modelBuilder.Entity("TT.Entities.Phattu", b =>
                {
                    b.Navigation("daotrangs");

                    b.Navigation("phattudaotrangs");

                    b.Navigation("tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
