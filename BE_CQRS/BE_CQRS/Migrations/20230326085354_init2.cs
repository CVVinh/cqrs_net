using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CQRS.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailProductInformation",
                schema: "public",
                table: "DetailProductInformation");

            migrationBuilder.RenameTable(
                name: "DetailProductInformation",
                schema: "public",
                newName: "ProductUnit",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_DetailProductInformation_ProductId",
                schema: "public",
                table: "ProductUnit",
                newName: "IX_ProductUnit_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductUnit",
                schema: "public",
                table: "ProductUnit",
                columns: new[] { "UnitId", "ProductId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductUnit",
                schema: "public",
                table: "ProductUnit");

            migrationBuilder.RenameTable(
                name: "ProductUnit",
                schema: "public",
                newName: "DetailProductInformation",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_ProductUnit_ProductId",
                schema: "public",
                table: "DetailProductInformation",
                newName: "IX_DetailProductInformation_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailProductInformation",
                schema: "public",
                table: "DetailProductInformation",
                columns: new[] { "UnitId", "ProductId" });
        }
    }
}
