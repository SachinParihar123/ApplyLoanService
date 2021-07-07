using ApplyLoanService.Controllers;
using ApplyLoanService.Models;
using ApplyLoanService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApplyLoanUnitTest
{
    public class LoanDetailsControllerUnitTest
    {
        private Mock<ILoanService> mock;
        private LoanDetailsController controller;
        private LoanDetails loanDetails;

        public LoanDetailsControllerUnitTest()
        {
            mock = new Mock<ILoanService>();
            controller = new LoanDetailsController(mock.Object);
            loanDetails = new LoanDetails()
            {
                id = 1,
                CustomerId="R-111",
                LoanType="Educational",
                LoanAmount=1000000,
                LoanIssueDate = new DateTime(2021, 12, 23),
                RateOfInterest =10,
                LoanDuration=15,
                FatherName="Ramesh",
                Course="BE",
                CourseFee=100000,
                FatherOccupation="HR",
                FatherTotalExperience=5,
                FatherExperienceWithCurrentComapany=2,
                RationCardNumber="ASD12345D",
                FatherAnnualIncomme=10000,
                CompanyName="Cognizant",
                AnnualIncomme=1000000,
                Designation="PAT",
                TotalExperience=4,
                ExperienceWithCurrentComapany=2

            };
        }
        [Fact]
        public void AddLoanDetail_ValidInput_ReturnsOkResult()
        {
            mock.Setup(p => p.AddLoanDetails(loanDetails)).Returns("Loan Details Added");
            var result = (OkObjectResult)controller.AddLoanDetail(loanDetails);
            Assert.Equal(200, result.StatusCode);

        }
        [Fact]
        public void AddLoanDetail_InValidInput_ReturnsBadRequest()
        {
            mock.Setup(p => p.AddLoanDetails(null)).Returns("Please Provide the loan details");
            var result = (BadRequestObjectResult)controller.AddLoanDetail(null);
            Assert.Equal(400, result.StatusCode);

        }
        [Fact]
        public void GetLoanDetails_ValidData_ReturnsOkResult()
        {
            List<LoanDetails> list = new List<LoanDetails>();
            list.Add(loanDetails);
            mock.Setup(p => p.getDetails("R-111")).Returns(list);
            var result = (OkObjectResult)controller.GetLoanDetails("R-111");
            Assert.Equal(200, result.StatusCode);

        }
        [Fact]
        public void GetLoanDetails_InValidData_ReturnsNoContentResult()
        {
            List<LoanDetails> list = new List<LoanDetails>();
            mock.Setup(p => p.getDetails("R-111")).Returns(list);
            var result = (NoContentResult)controller.GetLoanDetails("R-111");
            Assert.Equal(204, result.StatusCode);

        }
    }
}
