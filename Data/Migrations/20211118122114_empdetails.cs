using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamaERP.Data.Migrations
{
    public partial class empdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCEmployeeDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(maxLength: 500, nullable: true),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    Addr = table.Column<string>(maxLength: 500, nullable: true),
                    Department = table.Column<string>(maxLength: 500, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 500, nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCEmployeeDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ACCPurchases",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvancPaymentID = table.Column<int>(nullable: false),
                    SuplierName = table.Column<string>(maxLength: 500, nullable: true),
                    EmployeeName = table.Column<string>(maxLength: 500, nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(maxLength: 500, nullable: true),
                    PurchaseNo = table.Column<string>(maxLength: 50, nullable: true),
                    PruchaseDate = table.Column<DateTime>(nullable: false),
                    Qty = table.Column<double>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    TotalOtherCurrency = table.Column<decimal>(maxLength: 20, nullable: false),
                    Currency = table.Column<string>(maxLength: 20, nullable: true),
                    OtherCurrency = table.Column<string>(maxLength: 20, nullable: true),
                    ApprovedBy = table.Column<string>(maxLength: 500, nullable: true),
                    AddedBy = table.Column<string>(nullable: true),
                    AddingDate = table.Column<DateTime>(nullable: false),
                    ActiveOrNot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCPurchases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCEmployeeDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ACCPurchases",
                schema: "dbo");
        }
    }
}
