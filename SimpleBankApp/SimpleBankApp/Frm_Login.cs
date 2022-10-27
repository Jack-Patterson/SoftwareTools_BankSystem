using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBankApp
{
    public partial class Frm_Login : Form
    {
        Account newAccount = new Account(012345, "Jack", "AIB1234123", 123123, 50.25f);
        List<Account> accounts = new List<Account>();
        public Frm_Login()
        {
            InitializeComponent();

            accounts.Add(newAccount);
            accounts.Add(new Account(007123, "Hyden", "AIB555666", 007123, 0.00f));
            accounts.Add(new Account(75123, "Joe", "AIB333444", 12375, 0.00f));
            accounts.Add(new Account(69123, "Corey", "AIB111222", 12369, 0.00f));
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            bool accountValidated = false;
            bool accountNumberFound = false;

            Account LoggedInAccount = new Account();

            foreach (Account userAccount in accounts)
            {
                if (Convert.ToInt64(TxtBox_AccountNumber.Text) == userAccount.getAccountID() && Convert.ToInt64(TxtBox_PAC.Text) == userAccount.getPac())
                {
                    LoggedInAccount = userAccount;

                    accountValidated = true;
                }

                if (Convert.ToInt64(TxtBox_AccountNumber.Text) == userAccount.getAccountID() && Convert.ToInt64(TxtBox_PAC.Text) != userAccount.getPac())
                {
                    accountNumberFound = true;
                }
            }

            if (accountValidated)
            {
                Frm_AccountMainPage userMainPage = new Frm_AccountMainPage(this, LoggedInAccount);

                this.Visible = false;

                userMainPage.Show();
            }
            else if (accountNumberFound)
            {
                MessageBox.Show("Incorrect password entered");

                TxtBox_PAC.Text = "";
            }
            else
            {
                MessageBox.Show("No Account found");

                TxtBox_AccountNumber.Text = "";
                TxtBox_PAC.Text = "";
            }
        }
    }
}
