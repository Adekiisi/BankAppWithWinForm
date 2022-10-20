using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface ICustomer
    {
        bool CreateAcct(double amount, string AccType);
        void ViewAllAccount();
    }
}
