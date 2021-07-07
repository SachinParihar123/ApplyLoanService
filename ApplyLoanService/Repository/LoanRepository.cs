using ApplyLoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Repository
{
    public class LoanRepository : ILoanRepository
    {
        readonly LoanContext context;
        public LoanRepository(LoanContext loancontext)
        {
            context = loancontext;
        }
        public string Add(LoanDetails loanDetails)
        {
             context.LoanDetails.Add(loanDetails);
            context.SaveChanges();
            return ("Loan Details Added");

        }
        public List<LoanDetails> getLoanDetails(string id)
        {
            List<LoanDetails> list = context.LoanDetails.Where(l => l.CustomerId == id).ToList();
            return list;

        }
    }
}
