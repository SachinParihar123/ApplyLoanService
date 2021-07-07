using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyLoanService.Models
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions options)
            : base(options)
    {
    }
    public DbSet<LoanDetails> LoanDetails { get; set; }
    
    }
}
