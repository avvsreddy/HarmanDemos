using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatelogApp.Migrations
{
    /// <inheritdoc />
    public partial class TPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersSupplierID",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "People");

            migrationBuilder.RenameColumn(
                name: "SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "SuppliersId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersSupplierID",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersId");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "People",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_People_SuppliersId",
                table: "ProductSupplier",
                column: "SuppliersId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_People_SuppliersId",
                table: "ProductSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "SuppliersId",
                table: "ProductSupplier",
                newName: "SuppliersSupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSupplier_SuppliersId",
                table: "ProductSupplier",
                newName: "IX_ProductSupplier_SuppliersSupplierID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Suppliers",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "SupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersSupplierID",
                table: "ProductSupplier",
                column: "SuppliersSupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
