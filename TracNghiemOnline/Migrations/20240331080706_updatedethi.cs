using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class updatedethi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mota",
                table: "Monhocs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mota",
                table: "Monhocs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
