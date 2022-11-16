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
    public class Validator
    {
        public static Account AreDetailValid(String accNumber, String PAC)
        {
            if(!EmptyTextCheck(accNumber,PAC)) 
            {
                if(NumericCheck(accNumber) && NumericCheck(PAC)) 
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
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found");
                    }
                }
                else
                {
                    MessageBox.Show("Credentials must be numeric");
                }
            }
            else
            {
                MessageBox.Show("Text boxes cannot be empty");
            }
            return null;
        }

        public static Account AccountFound(int accNumber) 
        {
            return DBConnector.GetUserById(accNumber);
        }

        public static Boolean NumericCheck(String s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static Boolean EmptyTextCheck(String accNumber, String PAC)
        {
            if(accNumber.Equals("") || PAC.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
