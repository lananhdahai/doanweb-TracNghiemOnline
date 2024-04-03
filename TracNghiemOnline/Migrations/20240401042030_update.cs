using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_DapAn_DapAnId",
                table: "Cauhois");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DapAn",
                table: "DapAn");

            migrationBuilder.RenameTable(
                name: "DapAn",
                newName: "DapAns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DapAns",
                table: "DapAns",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_DapAns_DapAnId",
                table: "Cauhois",
                column: "DapAnId",
                principalTable: "DapAns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cauhois_DapAns_DapAnId",
                table: "Cauhois");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DapAns",
                table: "DapAns");

            migrationBuilder.RenameTable(
                name: "DapAns",
                newName: "DapAn");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DapAn",
                table: "DapAn",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cauhois_DapAn_DapAnId",
                table: "Cauhois",
                column: "DapAnId",
                principalTable: "DapAn",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
