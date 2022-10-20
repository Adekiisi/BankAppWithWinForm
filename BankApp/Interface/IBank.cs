using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface IBank
    {
        bool CreateCustomer(string firstname, string lastname, string email, string password);
    }
}
