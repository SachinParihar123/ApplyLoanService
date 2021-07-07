using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApplyLoanService.Models;
using ApplyLoanService.Services;

namespace ApplyLoanService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanDetailsController : ControllerBase
    {
        private readonly ILoanService loanservice;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(LoanDetailsController));
        public LoanDetailsController(ILoanService loanService)
        {
            loanservice = loanService;
        }
        [HttpGet("{id}")]
        public IActionResult GetLoanDetails(string id)
           {
            _log4net.Info("Customer ID " + id + " Entered For Searching");
            _log4net.Info("Calling getDetailsmethod of service from controller");
            List<LoanDetails> list = loanservice.getDetails(id);
            if (list.Count==0)
            {
                return NoContent();
            }
            else
            {
                _log4net.Info("Returns Loan Details" + list);
                return Ok(list);
            }
           }
        [HttpPost]
        public IActionResult AddLoanDetail([FromBody] LoanDetails loanDetails)
        {
            _log4net.Info(" Entered For Apply Loan");
            if (loanDetails == null)
            {
                _log4net.Info("Failed due to Invalid detail");
                return BadRequest("Please provide the loan details");
            }
            else
            {
                _log4net.Info("Calling AddLoanDetails method of service from controller");
                loanservice.AddLoanDetails(loanDetails);
                _log4net.Info("Returns Loan Details Added");
                return Ok("Loan Details Added");
            }
        
        }

    }
}
