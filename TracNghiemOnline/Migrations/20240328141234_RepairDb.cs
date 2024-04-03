using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class RepairDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_Monhocs_IdmonNavigationId",
                table: "Cauhois");

            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_Mucdokhos_IddokhoNavigationId",
                table: "Cauhois");

            migrationBuilder.DropForeignKey(
                name: "FK_Ketquas_Cauhois_IdcauhoiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ketquas_Dethis_IddethiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ketquas_Taikhoan_IdtkNavigationId",
                table: "Ketquas");

            migrationBuilder.DropForeignKey(
                name: "FK_Monhocs_Lophocs_IdlopNavigationId",
                table: "Monhocs");

            migrationBuilder.DropTable(
                name: "CauhoiDethi");

            migrationBuilder.DropTable(
                name: "DethiTaikhoan");

            migrationBuilder.DropTable(
                name: "Mucdokhos");

            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.DropIndex(
                name: "IX_Monhocs_IdlopNavigationId",
                table: "Monhocs");

            migrationBuilder.DropIndex(
                name: "IX_Ketquas_IdcauhoiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Ketquas_IddethiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Ketquas_IdtkNavigationId",
                table: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Cauhois_IddokhoNavigationId",
                table: "Cauhois");

            migrationBuilder.DropIndex(
                name: "IX_Cauhois_IdmonNavigationId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "Idlop",
                table: "Monhocs");

            migrationBuilder.DropColumn(
                name: "IdlopNavigationId",
                table: "Monhocs");

            migrationBuilder.DropColumn(
                name: "Da",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "Idcauhoi",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "IdcauhoiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "Iddethi",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "IddethiNavigationId",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "IdtkNavigationId",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "Ngaythi",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "Thoigianthi",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "Iddokho",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "IddokhoNavigationId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "IdmonNavigationId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "Imgch",
                table: "Cauhois");

            migrationBuilder.RenameColumn(
                name: "Slcau",
                table: "Dethis",
                newName: "SlCau");

            migrationBuilder.RenameColumn(
                name: "Videoch",
                table: "Cauhois",
                newName: "Video");

            migrationBuilder.RenameColumn(
                name: "Loigiai",
                table: "Cauhois",
                newName: "Khac");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Monhocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Tenlop",
                table: "Lophocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DapAn",
                table: "Ketquas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DethiId",
                table: "Ketquas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SlCau",
                table: "Dethis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gio",
                table: "Dethis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LophocId",
                table: "Dethis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonhocId",
                table: "Dethis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Dethis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Noidung",
                table: "Dethis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phut",
                table: "Dethis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DethiId",
                table: "Cauhois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cauhois",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KetquaId",
                table: "Cauhois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ketquas_DethiId",
                table: "Ketquas",
                column: "DethiId");

            migrationBuilder.CreateIndex(
                name: "IX_Dethis_LophocId",
                table: "Dethis",
                column: "LophocId");

            migrationBuilder.CreateIndex(
                name: "IX_Dethis_MonhocId",
                table: "Dethis",
                column: "MonhocId");

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_DethiId",
                table: "Cauhois",
                column: "DethiId");

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_KetquaId",
                table: "Cauhois",
                column: "KetquaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_Dethis_DethiId",
                table: "Cauhois",
                column: "DethiId",
                principalTable: "Dethis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_Ketquas_KetquaId",
                table: "Cauhois",
                column: "KetquaId",
                principalTable: "Ketquas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dethis_Lophocs_LophocId",
                table: "Dethis",
                column: "LophocId",
                principalTable: "Lophocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dethis_Monhocs_MonhocId",
                table: "Dethis",
                column: "MonhocId",
                principalTable: "Monhocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ketquas_Dethis_DethiId",
                table: "Ketquas",
                column: "DethiId",
                principalTable: "Dethis",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_Dethis_DethiId",
                table: "Cauhois");

            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_Ketquas_KetquaId",
                table: "Cauhois");

            migrationBuilder.DropForeignKey(
                name: "FK_Dethis_Lophocs_LophocId",
                table: "Dethis");

            migrationBuilder.DropForeignKey(
                name: "FK_Dethis_Monhocs_MonhocId",
                table: "Dethis");

            migrationBuilder.DropForeignKey(
                name: "FK_Ketquas_Dethis_DethiId",
                table: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Ketquas_DethiId",
                table: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Dethis_LophocId",
                table: "Dethis");

            migrationBuilder.DropIndex(
                name: "IX_Dethis_MonhocId",
                table: "Dethis");

            migrationBuilder.DropIndex(
                name: "IX_Cauhois_DethiId",
                table: "Cauhois");

            migrationBuilder.DropIndex(
                name: "IX_Cauhois_KetquaId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Monhocs");

            migrationBuilder.DropColumn(
                name: "DapAn",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "DethiId",
                table: "Ketquas");

            migrationBuilder.DropColumn(
                name: "Gio",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "LophocId",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "MonhocId",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "Noidung",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "Phut",
                table: "Dethis");

            migrationBuilder.DropColumn(
                name: "DethiId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "KetquaId",
                table: "Cauhois");

            migrationBuilder.RenameColumn(
                name: "SlCau",
                table: "Dethis",
                newName: "Slcau");

            migrationBuilder.RenameColumn(
                name: "Video",
                table: "Cauhois",
                newName: "Videoch");

            migrationBuilder.RenameColumn(
                name: "Khac",
                table: "Cauhois",
                newName: "Loigiai");

            migrationBuilder.AddColumn<int>(
                name: "Idlop",
                table: "Monhocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdlopNavigationId",
                table: "Monhocs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tenlop",
                table: "Lophocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Da",
                table: "Ketquas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Idcauhoi",
                table: "Ketquas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "IdcauhoiNavigationId",
                table: "Ketquas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Iddethi",
                table: "Ketquas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IddethiNavigationId",
                table: "Ketquas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdtkNavigationId",
                table: "Ketquas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Slcau",
                table: "Dethis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaythi",
                table: "Dethis",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Thoigianthi",
                table: "Dethis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Iddokho",
                table: "Cauhois",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IddokhoNavigationId",
                table: "Cauhois",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdmonNavigationId",
                table: "Cauhois",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imgch",
                table: "Cauhois",
                type: "varbinary(max)",
                nullable: true);

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
                    IdloaitkNavigationId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idloaitk = table.Column<int>(type: "int", nullable: false),
                    Matkhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sdt = table.Column<long>(type: "bigint", nullable: true),
                    Tentaikhoan = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Monhocs_IdlopNavigationId",
                table: "Monhocs",
                column: "IdlopNavigationId");

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
                name: "IX_Cauhois_IddokhoNavigationId",
                table: "Cauhois",
                column: "IddokhoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_IdmonNavigationId",
                table: "Cauhois",
                column: "IdmonNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_CauhoiDethi_IddethisId",
                table: "CauhoiDethi",
                column: "IddethisId");

            migrationBuilder.CreateIndex(
                name: "IX_DethiTaikhoan_IdtksId",
                table: "DethiTaikhoan",
                column: "IdtksId");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoan_IdloaitkNavigationId",
                table: "Taikhoan",
                column: "IdloaitkNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_Monhocs_IdmonNavigationId",
                table: "Cauhois",
                column: "IdmonNavigationId",
                principalTable: "Monhocs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_Mucdokhos_IddokhoNavigationId",
                table: "Cauhois",
                column: "IddokhoNavigationId",
                principalTable: "Mucdokhos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ketquas_Cauhois_IdcauhoiNavigationId",
                table: "Ketquas",
                column: "IdcauhoiNavigationId",
                principalTable: "Cauhois",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ketquas_Dethis_IddethiNavigationId",
                table: "Ketquas",
                column: "IddethiNavigationId",
                principalTable: "Dethis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ketquas_Taikhoan_IdtkNavigationId",
                table: "Ketquas",
                column: "IdtkNavigationId",
                principalTable: "Taikhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monhocs_Lophocs_IdlopNavigationId",
                table: "Monhocs",
                column: "IdlopNavigationId",
                principalTable: "Lophocs",
                principalColumn: "Id");
        }
    }
}
