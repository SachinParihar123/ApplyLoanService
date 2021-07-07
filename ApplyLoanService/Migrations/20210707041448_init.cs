using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplyLoanService.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanAmount = table.Column<long>(type: "bigint", nullable: false),
                    LoanIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateOfInterest = table.Column<int>(type: "int", nullable: false),
                    LoanDuration = table.Column<int>(type: "int", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseFee = table.Column<long>(type: "bigint", nullable: false),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherTotalExperience = table.Column<int>(type: "int", nullable: false),
                    FatherExperienceWithCurrentComapany = table.Column<int>(type: "int", nullable: false),
                    RationCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherAnnualIncomme = table.Column<long>(type: "bigint", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnualIncomme = table.Column<long>(type: "bigint", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalExperience = table.Column<int>(type: "int", nullable: false),
                    ExperienceWithCurrentComapany = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanDetails");
        }
    }
}
