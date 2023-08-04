using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TT.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chuas",
                columns: table => new
                {
                    chuaId = table.Column<int>(type: "int", nullable: false),
                    capnhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tenChua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trutri = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuas", x => x.chuaId);
                });

            migrationBuilder.CreateTable(
                name: "Kieuthanhviens",
                columns: table => new
                {
                    kieuthanhvienId = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenKieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kieuthanhviens", x => x.kieuthanhvienId);
                });

            migrationBuilder.CreateTable(
                name: "phattus",
                columns: table => new
                {
                    phatTuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anhChup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    daHoanTuc = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ngayHoanTuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayXuatGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phapDanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenDem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    chuaId = table.Column<int>(type: "int", nullable: false),
                    kieuthanhvienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phattus", x => x.phatTuId);
                    table.ForeignKey(
                        name: "FK_phattus_chuas_chuaId",
                        column: x => x.chuaId,
                        principalTable: "chuas",
                        principalColumn: "chuaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phattus_Kieuthanhviens_kieuthanhvienId",
                        column: x => x.kieuthanhvienId,
                        principalTable: "Kieuthanhviens",
                        principalColumn: "kieuthanhvienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "daotrangs",
                columns: table => new
                {
                    daotrangId = table.Column<int>(type: "int", nullable: false),
                    daKetThuc = table.Column<int>(type: "int", nullable: false),
                    noiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noiToChuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soThanhVienThamGia = table.Column<int>(type: "int", nullable: false),
                    thoiGianToChuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nguoiTruTri = table.Column<int>(type: "int", nullable: false),
                    phatTuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_daotrangs", x => x.daotrangId);
                    table.ForeignKey(
                        name: "FK_daotrangs_phattus_phatTuId",
                        column: x => x.phatTuId,
                        principalTable: "phattus",
                        principalColumn: "phatTuId");
                });

            migrationBuilder.CreateTable(
                name: "tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stoken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expired = table.Column<int>(type: "int", nullable: true),
                    revoked = table.Column<int>(type: "int", nullable: true),
                    phattuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tokens_phattus_phattuId",
                        column: x => x.phattuId,
                        principalTable: "phattus",
                        principalColumn: "phatTuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dondangkis",
                columns: table => new
                {
                    dondangkiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayGuiDon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayXuLy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trangThaiDon = table.Column<int>(type: "int", nullable: false),
                    daotrangId = table.Column<int>(type: "int", nullable: false),
                    phattuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dondangkis", x => x.dondangkiId);
                    table.ForeignKey(
                        name: "FK_dondangkis_daotrangs_daotrangId",
                        column: x => x.daotrangId,
                        principalTable: "daotrangs",
                        principalColumn: "daotrangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dondangkis_phattus_phattuId",
                        column: x => x.phattuId,
                        principalTable: "phattus",
                        principalColumn: "phatTuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phattudaotrangs",
                columns: table => new
                {
                    phattudaotrangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    daThamGia = table.Column<int>(type: "int", nullable: false),
                    lyDoKhongThamGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    daotrangId = table.Column<int>(type: "int", nullable: false),
                    phattuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phattudaotrangs", x => x.phattudaotrangId);
                    table.ForeignKey(
                        name: "FK_phattudaotrangs_daotrangs_daotrangId",
                        column: x => x.daotrangId,
                        principalTable: "daotrangs",
                        principalColumn: "daotrangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phattudaotrangs_phattus_phattuId",
                        column: x => x.phattuId,
                        principalTable: "phattus",
                        principalColumn: "phatTuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_daotrangs_phatTuId",
                table: "daotrangs",
                column: "phatTuId");

            migrationBuilder.CreateIndex(
                name: "IX_dondangkis_daotrangId",
                table: "dondangkis",
                column: "daotrangId");

            migrationBuilder.CreateIndex(
                name: "IX_dondangkis_phattuId",
                table: "dondangkis",
                column: "phattuId");

            migrationBuilder.CreateIndex(
                name: "IX_phattudaotrangs_daotrangId",
                table: "phattudaotrangs",
                column: "daotrangId");

            migrationBuilder.CreateIndex(
                name: "IX_phattudaotrangs_phattuId",
                table: "phattudaotrangs",
                column: "phattuId");

            migrationBuilder.CreateIndex(
                name: "IX_phattus_chuaId",
                table: "phattus",
                column: "chuaId");

            migrationBuilder.CreateIndex(
                name: "IX_phattus_kieuthanhvienId",
                table: "phattus",
                column: "kieuthanhvienId");

            migrationBuilder.CreateIndex(
                name: "IX_tokens_phattuId",
                table: "tokens",
                column: "phattuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dondangkis");

            migrationBuilder.DropTable(
                name: "phattudaotrangs");

            migrationBuilder.DropTable(
                name: "tokens");

            migrationBuilder.DropTable(
                name: "daotrangs");

            migrationBuilder.DropTable(
                name: "phattus");

            migrationBuilder.DropTable(
                name: "chuas");

            migrationBuilder.DropTable(
                name: "Kieuthanhviens");
        }
    }
}
