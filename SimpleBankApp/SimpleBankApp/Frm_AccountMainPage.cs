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
    public partial class Frm_AccountMainPage : Form
    {
        private Frm_Login Parentform;
        private Account UserAccount;

        public Frm_AccountMainPage()
        {
            InitializeComponent();
        }

        public Frm_AccountMainPage(Frm_Login parent, Account userAccount)
        {
            InitializeComponent();
            Parentform = parent;    
            UserAccount = userAccount;  
        }
    }
}
