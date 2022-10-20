using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Implementations
{
    public class Bank : IBank
    {
        public Dictionary<string, Customer> AllCustomer;
        public Bank()
        {
            AllCustomer = new Dictionary<string, Customer>();
        }
        public Customer Login(string email, string password)
        {
            if (!AllCustomer.ContainsKey(email) || AllCustomer == null) return null;
            if (AllCustomer[email].customerModel.Password != password) return null;
            return AllCustomer[email];
        }
        public bool CreateCustomer(string firstname, string lastname, string email, string password)
        {
            Customer customer = new Customer(firstname, lastname, email, password);
            AllCustomer.Add(email, customer);
            return true;
        }
    }
}
