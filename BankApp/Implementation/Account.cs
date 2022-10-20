using BankApp.Interfaces;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Model;

namespace BankApp.Implementations
{
    public class Account : IAccount
    {
        public static int Count = 0;
        public readonly AccountModel AccountObj = new AccountModel();

        public Account(int userId, string accountType, double amount)
        {
            AccountObj.AccountNo = GenerateAcctNo();
            AccountObj.AccountType = accountType;
            AccountObj.Balance = amount;
            AccountObj.userId = userId;
            AddTransactions(AccountObj.Balance, amount, "First deposit");
        }

        private void AddTransactions(double balance, double amount, string description)
        {
            string date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            AccountObj.TransactionList.Add(new TransactionModel { Date = date, Description = description, Balance = balance, Amount = amount });
        }
        public double Balance()
        {
            return AccountObj.Balance;
        }

        public bool Deposit(string description, double amount)
        {
            if (AccountObj.Balance <= 0) return false;
            AccountObj.Balance += amount;
            AddTransactions(AccountObj.Balance, amount, "Credit Alert!");
            return true;
        }

        public string GenerateAcctNo()
        {
            string acctNo = "012345678" + Count;
            Count++;
            return acctNo;
        }


        public void ViewAllTransactions(List<TransactionModel> transactions)
        {
            throw new NotImplementedException();
        }
        public bool Transfer(string description, double amount, string destinationAcct)
        {
            return false;
        }
        public bool Withdrawal(string description, double amount)
        {
            if ((AccountObj.Balance - amount < 1000 && AccountObj.AccountType == "Savings") || AccountObj.Balance - amount < 0)
            {
                return false;
            }

            AccountObj.Balance -= amount;
            AddTransactions(AccountObj.Balance, amount, "Debit Alert!");
            return true;
        }

       
    }
}
