using BankApp.Interfaces;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Implementations
{
    public class Customer: ICustomer
    {
        public readonly CustomerModel customerModel = new CustomerModel();
        public List<Account> accounts = new List<Account>();
        private static int count = 1;
        public Customer(string firstname, string lastname, string email, string password)
        {
            customerModel.UserId = count;
            customerModel.Name = firstname + " " + lastname;
            customerModel.Email = email;
            customerModel.Password = password;
            count++;
        }

        public bool CreateAcct(double amount, string AccType)
        {
            Account acct = new Account(customerModel.UserId, AccType, amount);
            accounts.Add(acct);
            return true;
        }

        public void ViewAllAccount()
        {
            throw new NotImplementedException();
        }
    }
}
