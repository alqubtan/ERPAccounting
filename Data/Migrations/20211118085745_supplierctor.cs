using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Data.Migrations
{
    public partial class supplierctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCSupliers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuplierName = table.Column<string>(maxLength: 500, nullable: true),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Addr = table.Column<string>(maxLength: 500, nullable: true),
                    SuplierType = table.Column<string>(maxLength: 500, nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCSupliers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCSupliers",
                schema: "dbo");
        }
    }
}
