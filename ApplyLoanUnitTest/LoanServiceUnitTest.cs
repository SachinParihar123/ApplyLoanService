using ApplyLoanService.Models;
using ApplyLoanService.Repository;
using ApplyLoanService.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApplyLoanUnitTest
{
   public  class LoanServiceUnitTest
    {
        private Mock<ILoanRepository> mock;
        private LoanService service;
        private LoanDetails loanDetails;

        public LoanServiceUnitTest()
        {
            mock = new Mock<ILoanRepository>();
            service = new LoanService(mock.Object);
            loanDetails = new LoanDetails()
            {
                id = 1,
                CustomerId = "R-111",
                LoanType = "Educational",
                LoanAmount = 1000000,
                LoanIssueDate = new DateTime(2021, 12, 23),
                RateOfInterest = 10,
                LoanDuration = 15,
                FatherName = "Ramesh",
                Course = "BE",
                CourseFee = 100000,
                FatherOccupation = "HR",
                FatherTotalExperience = 5,
                FatherExperienceWithCurrentComapany = 2,
                RationCardNumber = "ASD12345D",
                FatherAnnualIncomme = 10000,
                CompanyName = "Cognizant",
                AnnualIncomme = 1000000,
                Designation = "PAT",
                TotalExperience = 4,
                ExperienceWithCurrentComapany = 2

            };
        }
        [Fact]
        public void AddLoanDetails_ValidInput_ReturnsLoanDetailsAdded()
        {
            mock.Setup(p => p.Add(loanDetails)).Returns("Loan Details Added");
            var result = service.AddLoanDetails(loanDetails);
            Assert.Equal("Loan Details Added", result);

        }
        [Fact]
        public void GetDetails_ValidData_ReturnsListOfLaonDetails()
        {
            List<LoanDetails> list = new List<LoanDetails>();
            list.Add(loanDetails);
            mock.Setup(p => p.getLoanDetails("R-111")).Returns(list);
            var result = service.getDetails("R-111");
            Assert.Equal(list,result);

        }
    }
}
