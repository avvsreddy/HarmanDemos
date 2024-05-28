using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatelogApp.Migrations
{
    /// <inheritdoc />
    public partial class TPH1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "People",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");
        }
    }
}
