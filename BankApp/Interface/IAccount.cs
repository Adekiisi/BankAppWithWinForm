using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Interfaces
{
    public interface IAccount
    {
        string GenerateAcctNo();
        double Balance();
        bool Deposit(string description, double amount);
        bool Withdrawal(string description, double amount);
        bool Transfer (string description, double amount, string destinationAcc);
        void ViewAllTransactions(List<TransactionModel> transactions);
    }
}
