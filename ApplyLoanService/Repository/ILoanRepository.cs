using ApplyLoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Repository
{
    public interface ILoanRepository
    {
        string Add(LoanDetails loanDetails);
        List<LoanDetails> getLoanDetails(string id); 
    }
}
