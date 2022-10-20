using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class TransactionModel
    {
        public string Date { get; set; }
        
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
    }
}
