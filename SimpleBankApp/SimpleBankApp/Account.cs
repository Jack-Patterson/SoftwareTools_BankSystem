using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankApp
{
    public class Account
    {

        int AccountId;
        string Name;
        string Iban;
        int Pac;
        float Balance; 
 
        public Account(int AccountId, string Name, string Iban, int Pac, float Balance)
        {
            this.AccountId = AccountId;
            this.Name = Name;
            this.Iban = Iban;
            this.Pac = Pac;
            this.Balance = Balance;
        }

        public int getAccountId()
        {
            return AccountId;
        }

        public string getAccountName()
        {
            return Name;
        }

        public string getIban()
        {
            return Iban;
        }

        public int getPac()
        {
            return Pac;
        }

        public float getBalance()
        {
            return Balance;
        }

        public void setaccountId(int customerAccountId)
        {
            AccountId = customerAccountId;
        }

        public void setAccountName(string customerAccountName)
        {
            Name = customerAccountName;
        }

        public void setIban(string customerIban)
        {
            Iban = customerIban;
        }

        public void setPac(int customerPac)
        {
            Pac = customerPac;
        }

        public void setBalance(float customerBalance)
        {
            Balance = customerBalance;
        }

    }
}
