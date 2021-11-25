using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Data.Migrations
{
    public partial class sdkjfksdjfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ACCAdvancePayment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(maxLength: 500, nullable: true),
                    PaymentReason = table.Column<string>(maxLength: 500, nullable: true),
                    Ammount = table.Column<decimal>(nullable: false),
                    Currency = table.Column<string>(maxLength: 20, nullable: true),
                    Remaining = table.Column<decimal>(nullable: false),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    TotalOtherCurrency = table.Column<decimal>(nullable: false),
                    ApprovedBy = table.Column<string>(nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCAdvancePayment", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCAdvancePayment",
                schema: "dbo");
        }
    }
}
