using ApplyLoanService.Models;
using ApplyLoanService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Services
{
    public class LoanService : ILoanService
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(LoanService));
        private ILoanRepository repository;
        public LoanService(ILoanRepository loanrepository)
        {
            repository= loanrepository;
        }
        public string AddLoanDetails(LoanDetails loanDetails)
        {
            _log4net.Info("Calling Add method of repository from service");
            return repository.Add(loanDetails); 
        }
        public List<LoanDetails> getDetails(string id)
        {
            _log4net.Info("Calling getLoanDetails method of repository from service");
            List<LoanDetails> list =  repository.getLoanDetails(id);
            return list;
        }
    }
}
