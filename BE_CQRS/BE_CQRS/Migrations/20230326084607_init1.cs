using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BE_CQRS.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "InformationProduct",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeUnit",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeProduct",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    TypeUnitId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoPro_DetailInfoPro",
                        column: x => x.TypeUnitId,
                        principalSchema: "public",
                        principalTable: "TypeUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    StanderNumber = table.Column<int>(type: "integer", nullable: false),
                    TypeUnitId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeUnit_Unit",
                        column: x => x.TypeUnitId,
                        principalSchema: "public",
                        principalTable: "TypeUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InformationTypeProduct",
                schema: "public",
                columns: table => new
                {
                    InformationProductId = table.Column<int>(type: "integer", nullable: false),
                    TypeProductId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationTypeProduct", x => new { x.InformationProductId, x.TypeProductId });
                    table.UniqueConstraint("AK_InformationTypeProduct_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoPro_InfoTypePro",
                        column: x => x.InformationProductId,
                        principalSchema: "public",
                        principalTable: "InformationProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypePro_InfoTypePro",
                        column: x => x.TypeProductId,
                        principalSchema: "public",
                        principalTable: "TypeProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    TypeProductId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypePro_Pro",
                        column: x => x.TypeProductId,
                        principalSchema: "public",
                        principalTable: "TypeProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailInformationTypeProduct",
                schema: "public",
                columns: table => new
                {
                    InformationTypeProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInformationTypeProduct", x => new { x.InformationTypeProductId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_InfoTypePro_DetailInfoTypePro",
                        column: x => x.InformationTypeProductId,
                        principalSchema: "public",
                        principalTable: "InformationTypeProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pro_DetailPro",
                        column: x => x.ProductId,
                        principalSchema: "public",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailProductInformation",
                schema: "public",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    UnitId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    UserCreated = table.Column<int>(type: "integer", nullable: true),
                    UserUpdated = table.Column<int>(type: "integer", nullable: true),
                    UserDeleted = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "date", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "date", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailProductInformation", x => new { x.UnitId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Product_ProUnit",
                        column: x => x.ProductId,
                        principalSchema: "public",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Unit_ProUnit",
                        column: x => x.UnitId,
                        principalSchema: "public",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailInformationTypeProduct_ProductId",
                schema: "public",
                table: "DetailInformationTypeProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailProductInformation_ProductId",
                schema: "public",
                table: "DetailProductInformation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InformationTypeProduct_TypeProductId",
                schema: "public",
                table: "InformationTypeProduct",
                column: "TypeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TypeProductId",
                schema: "public",
                table: "Product",
                column: "TypeProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeProduct_TypeUnitId",
                schema: "public",
                table: "TypeProduct",
                column: "TypeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_TypeUnitId",
                schema: "public",
                table: "Unit",
                column: "TypeUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailInformationTypeProduct",
                schema: "public");

            migrationBuilder.DropTable(
                name: "DetailProductInformation",
                schema: "public");

            migrationBuilder.DropTable(
                name: "InformationTypeProduct",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Unit",
                schema: "public");

            migrationBuilder.DropTable(
                name: "InformationProduct",
                schema: "public");

            migrationBuilder.DropTable(
                name: "TypeProduct",
                schema: "public");

            migrationBuilder.DropTable(
                name: "TypeUnit",
                schema: "public");
        }
    }
}
