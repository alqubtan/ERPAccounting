using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Data.Migrations
{
    public partial class fixedassets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCFixedAssets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetName = table.Column<string>(maxLength: 500, nullable: true),
                    Category = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    EstimatedValue = table.Column<decimal>(maxLength: 500, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    BrandName = table.Column<string>(maxLength: 500, nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCFixedAssets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCFixedAssets");
        }
    }
}
