using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dethis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thoigianthi = table.Column<int>(type: "int", nullable: true),
                    Slcau = table.Column<int>(type: "int", nullable: true),
                    Ngaythi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dethis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loaitks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loaitk1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaitks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lophocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenlop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mucdokhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tendk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mucdokhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idloaitk = table.Column<int>(type: "int", nullable: false),
                    Tentaikhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matkhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sdt = table.Column<long>(type: "bigint", nullable: true),
                    IdloaitkNavigationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Taikhoan_Loaitks_IdloaitkNavigationId",
                        column: x => x.IdloaitkNavigationId,
                        principalTable: "Loaitks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monhocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenmon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idlop = table.Column<int>(type: "int", nullable: false),
                    IdlopNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monhocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monhocs_Lophocs_IdlopNavigationId",
                        column: x => x.IdlopNavigationId,
                        principalTable: "Lophocs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DethiTaikhoan",
                columns: table => new
                {
                    IddethisId = table.Column<int>(type: "int", nullable: false),
                    IdtksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DethiTaikhoan", x => new { x.IddethisId, x.IdtksId });
                    table.ForeignKey(
                        name: "FK_DethiTaikhoan_Dethis_IddethisId",
                        column: x => x.IddethisId,
                        principalTable: "Dethis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DethiTaikhoan_Taikhoan_IdtksId",
                        column: x => x.IdtksId,
                        principalTable: "Taikhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cauhois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Noidung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loigiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idmon = table.Column<int>(type: "int", nullable: true),
                    Da = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iddokho = table.Column<int>(type: "int", nullable: true),
                    Imgch = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Videoch = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IddokhoNavigationId = table.Column<int>(type: "int", nullable: true),
                    IdmonNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cauhois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cauhois_Monhocs_IdmonNavigationId",
                        column: x => x.IdmonNavigationId,
                        principalTable: "Monhocs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cauhois_Mucdokhos_IddokhoNavigationId",
                        column: x => x.IddokhoNavigationId,
                        principalTable: "Mucdokhos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CauhoiDethi",
                columns: table => new
                {
                    IdcauhoisId = table.Column<int>(type: "int", nullable: false),
                    IddethisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauhoiDethi", x => new { x.IdcauhoisId, x.IddethisId });
                    table.ForeignKey(
                        name: "FK_CauhoiDethi_Cauhois_IdcauhoisId",
                        column: x => x.IdcauhoisId,
                        principalTable: "Cauhois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CauhoiDethi_Dethis_IddethisId",
                        column: x => x.IddethisId,
                        principalTable: "Dethis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ketquas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iddethi = table.Column<int>(type: "int", nullable: false),
                    Idcauhoi = table.Column<long>(type: "bigint", nullable: false),
                    Da = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdcauhoiNavigationId = table.Column<int>(type: "int", nullable: false),
                    IddethiNavigationId = table.Column<int>(type: "int", nullable: false),
                    IdtkNavigationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ketquas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ketquas_Cauhois_IdcauhoiNavigationId",
                        column: x => x.IdcauhoiNavigationId,
                        principalTable: "Cauhois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ketquas_Dethis_IddethiNavigationId",
                        column: x => x.IddethiNavigationId,
                        principalTable: "Dethis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ketquas_Taikhoan_IdtkNavigationId",
                        column: x => x.IdtkNavigationId,
                        principalTable: "Taikhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CauhoiDethi_IddethisId",
                table: "CauhoiDethi",
                column: "IddethisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_IddokhoNavigationId",
                table: "Cauhois",
                column: "IddokhoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_IdmonNavigationId",
                table: "Cauhois",
                column: "IdmonNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_DethiTaikhoan_IdtksId",
                table: "DethiTaikhoan",
                column: "IdtksId");

            migrationBuilder.CreateIndex(
                name: "IX_Ketquas_IdcauhoiNavigationId",
                table: "Ketquas",
                column: "IdcauhoiNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ketquas_IddethiNavigationId",
                table: "Ketquas",
                column: "IddethiNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ketquas_IdtkNavigationId",
                table: "Ketquas",
                column: "IdtkNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Monhocs_IdlopNavigationId",
                table: "Monhocs",
                column: "IdlopNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoan_IdloaitkNavigationId",
                table: "Taikhoan",
                column: "IdloaitkNavigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauhoiDethi");

            migrationBuilder.DropTable(
                name: "DethiTaikhoan");

            migrationBuilder.DropTable(
                name: "Ketquas");

            migrationBuilder.DropTable(
                name: "Cauhois");

            migrationBuilder.DropTable(
                name: "Dethis");

            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.DropTable(
                name: "Monhocs");

            migrationBuilder.DropTable(
                name: "Mucdokhos");

            migrationBuilder.DropTable(
                name: "Loaitks");

            migrationBuilder.DropTable(
                name: "Lophocs");
        }
    }
}
