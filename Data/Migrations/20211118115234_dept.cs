using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Data.Migrations
{
    public partial class dept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCDepartments",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    Disciption = table.Column<string>(nullable: true),
                    ActiveOrNot = table.Column<int>(nullable: false),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCDepartments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCDepartments",
                schema: "dbo");
        }
    }
}
