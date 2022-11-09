using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace SimpleBankApp
{
    /// <summary>
    /// Interaction logic for AccountMainPage.xaml
    /// </summary>
    public partial class frm_AccountMainPage : Window
    {
        private frm_Login Parentform;
        private Account UserAccount;
        private List<Transaction> TransactionList;

        public frm_AccountMainPage()
        {
            InitializeComponent();
        }

        public frm_AccountMainPage(frm_Login parent, Account userAccount)
        {
            InitializeComponent();
            Parentform = parent;
            UserAccount = userAccount;
            lbl_Welcome.Content += (" " + UserAccount.getAccountName());
            lbl_BalanceHeader.Content += (" € " + UserAccount.getBalance());
            TransactionList = DBConnector.GetTransactionsForID(userAccount.getAccountId());

            lstView_Transactions.ItemsSource= TransactionList;

        }

    }
}
