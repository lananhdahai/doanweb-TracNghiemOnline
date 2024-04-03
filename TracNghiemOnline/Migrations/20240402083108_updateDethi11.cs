using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracNghiemOnline.Migrations
{
    /// <inheritdoc />
    public partial class updateDethi11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Dethis",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Dethis");
        }
    }
}
