using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class DeleteKetqua : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_Ketquas_KetquaId",
                table: "Cauhois");

            migrationBuilder.DropTable(
                name: "Ketquas");

            migrationBuilder.DropIndex(
                name: "IX_Cauhois_KetquaId",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "KetquaId",
                table: "Cauhois");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KetquaId",
                table: "Cauhois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ketquas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DapAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DethiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ketquas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ketquas_Dethis_DethiId",
                        column: x => x.DethiId,
                        principalTable: "Dethis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cauhois_KetquaId",
                table: "Cauhois",
                column: "KetquaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ketquas_DethiId",
                table: "Ketquas",
                column: "DethiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_Ketquas_KetquaId",
                table: "Cauhois",
                column: "KetquaId",
                principalTable: "Ketquas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
