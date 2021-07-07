using ApplyLoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Services
{
    public interface ILoanService
    {
        string AddLoanDetails(LoanDetails loanDetails);
        List<LoanDetails> getDetails(string id);
    }
}
