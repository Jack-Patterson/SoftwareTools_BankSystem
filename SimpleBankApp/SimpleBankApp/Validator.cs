using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleBankApp
{
    internal class Validator
    {
        public static Account AreDetailValid(String accNumber, String PAC)
        {
            if(!EmptyTextCheck(accNumber,PAC)) 
            {
                if(AccNumericCheck(accNumber) && PACNumericCheck(PAC)) 
                {
                    Account userAccount = AccountFound(int.Parse(accNumber));
                    if(userAccount != null) 
                    {
                        if(int.Parse(PAC) == userAccount.getPac())
                        {
                            return userAccount;
                        }
                        else
                        {
                            MessageBox.Show("Inccorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found");
                    }
                }
                else
                {
                    MessageBox.Show("Credideitals must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Text boxes cannot be empty");
            }
            return null;
        }

        private static Account AccountFound(int accNumber) 
        {
            return DBConnector.GetUserById(accNumber);
        }

        private static Boolean AccNumericCheck(String accNumber)
        {
            for(int i = 0; i < accNumber.Length; i++)
            {
                if (!char.IsDigit(accNumber[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static Boolean PACNumericCheck(String PAC)
        {
            for (int i = 0; i < PAC.Length; i++)
            {
                if (!char.IsDigit(PAC[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static Boolean EmptyTextCheck(String accNumber, String PAC)
        {
            if(accNumber.Equals(null) || PAC.Equals(null))
            {
                return true;
            }
            return false;
        }
    }
}
