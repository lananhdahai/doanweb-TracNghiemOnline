using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class UpdateandAddDapAN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idmon",
                table: "Cauhois");

            migrationBuilder.DropColumn(
                name: "Video",
                table: "Cauhois");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cauhois",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            //migrationBuilder.AddColumn<int>(
            //    name: "DapAnId",
            //    table: "Cauhois",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "DapAn",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DapAn", x => x.ID);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cauhois_DapAnId",
            //    table: "Cauhois",
            //    column: "DapAnId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Cauhois_DapAn_DapAnId",
            //    table: "Cauhois",
            //    column: "DapAnId",
            //    principalTable: "DapAn",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Cauhois_DapAn_DapAnId",
            //    table: "Cauhois");

            //migrationBuilder.DropTable(
            //    name: "DapAn");

            //migrationBuilder.DropIndex(
            //    name: "IX_Cauhois_DapAnId",
            //    table: "Cauhois");

            //migrationBuilder.DropColumn(
            //    name: "DapAnId",
            //    table: "Cauhois");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cauhois",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Idmon",
                table: "Cauhois",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Video",
                table: "Cauhois",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
