using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPaymentCalculator.Models
{
    public class Loan
    {
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime EndDate { get; set; }
        public LoanInstallmentType InstallmentType { get; set; }
        public decimal NextInstallment { get; set; }

    }
}
