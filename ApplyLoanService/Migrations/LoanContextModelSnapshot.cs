// <auto-generated />
using System;
using ApplyLoanService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApplyLoanService.Migrations
{
    [DbContext(typeof(LoanContext))]
    partial class LoanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplyLoanService.Models.LoanDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AnnualIncomme")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CourseFee")
                        .HasColumnType("bigint");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceWithCurrentComapany")
                        .HasColumnType("int");

                    b.Property<long>("FatherAnnualIncomme")
                        .HasColumnType("bigint");

                    b.Property<int>("FatherExperienceWithCurrentComapany")
                        .HasColumnType("int");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherTotalExperience")
                        .HasColumnType("int");

                    b.Property<long>("LoanAmount")
                        .HasColumnType("bigint");

                    b.Property<int>("LoanDuration")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanIssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RateOfInterest")
                        .HasColumnType("int");

                    b.Property<string>("RationCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalExperience")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("LoanDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
