using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleBankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class frm_Login : Window
    {
        private Account userAccount;
        public frm_Login()
        {
            InitializeComponent();

        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            userAccount = Validator.AreDetailValid(txt_AccNumber.Text, txt_PAC.Text);

            if(userAccount != null ) 
            {
                frm_AccountMainPage mainPage = new frm_AccountMainPage(this, userAccount);

                txt_AccNumber.Text = "";

                txt_PAC.Text = "";

                this.Visibility = Visibility.Hidden;

                mainPage.Show();
            }

        }

        public void ChangeUserAccount(Account user_Account)
        {
            this.userAccount = user_Account;
        }

    }
}
