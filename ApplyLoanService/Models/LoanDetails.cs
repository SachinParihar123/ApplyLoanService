using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Models
{
    public class LoanDetails
    {
        public int id { get; set; }
        public string CustomerId { get; set; }
        public string LoanType { get; set; }
        public long LoanAmount { get; set; }
        public DateTime LoanIssueDate { get; set; }
        public int RateOfInterest { get; set; }     
        public int LoanDuration { get; set; }
        public string FatherName { get; set; }
        public string Course { get; set; }
        public long CourseFee { get; set; }
        public string FatherOccupation { get; set; }
        public int FatherTotalExperience { get; set; }
        public int FatherExperienceWithCurrentComapany { get; set; }
        public string RationCardNumber { get; set; }
        public long FatherAnnualIncomme { get; set; }
        public string CompanyName { get; set; }
        public long AnnualIncomme { get; set; }
        public string Designation { get; set; }
        public int TotalExperience { get; set; }
        public int ExperienceWithCurrentComapany { get; set; }



    }
}
