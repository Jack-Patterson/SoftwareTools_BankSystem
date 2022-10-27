using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankApp
{
    public class Account
    {

        int accountID;
        string accountName;
        string iban;
        int pac;
        float balance;

        public Account()
        {

        }

        public Account(int accountID, string accountName, string iban, int pac, float balance)
        {
            this.accountID = accountID;
            this.accountName = accountName;
            this.iban = iban;
            this.pac = pac;
            this.balance = balance;
        }

        public int getAccountID()
        {
            return accountID;
        }

        public string getAccountName()
        {
            return accountName;
        }

        public string getIban()
        {
            return iban;
        }

        public int getPac()
        {
            return pac;
        }

        public float getBalance()
        {
            return balance;
        }

        public void setAccountId(int customerAccountID)
        {
            accountID = customerAccountID;
        }

        public void setAccountName(string customerAccountName)
        {
            accountName = customerAccountName;
        }

        public void setIban(string customerIban)
        {
            iban = customerIban;
        }

        public void setPac(int customerPac)
        {
            pac = customerPac;
        }

        public void setBalance(float customerBalance)
        {
            balance = customerBalance;
        }

    }
}
