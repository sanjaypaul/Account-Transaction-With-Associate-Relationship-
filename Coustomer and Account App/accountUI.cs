using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coustomer_and_Account_App
{
    public partial class accountUI : Form
    {
        public accountUI()
        {
            InitializeComponent();
        }

        public Coustomer aCoustomer;
        Account aAccount = new Account();
        private void saveButton_Click(object sender, EventArgs e)
        {
          
            aCoustomer =new Coustomer();
            aCoustomer.Name = coustomerNameEntrytextBox.Text;
            aCoustomer.Email = coustomerEmailEntrytextBox.Text;

            aAccount.AccountNumber = accountNumberEntrytextBox.Text;
            aAccount.OpeningDate = openingDateEntrytextBox.Text;
            aCoustomer.AnAccount = aAccount;
            MessageBox.Show("Created");
        }

        private void dipositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(ammounttextBox.Text);
            aCoustomer.AnAccount.Diposit(amount);
            MessageBox.Show("Diposited");
        }

        private void withdrowButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(ammounttextBox.Text);
            aCoustomer.AnAccount.Withdow(amount);
            MessageBox.Show("Withdrewes");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            coustomerNameShowtextBox.Text = aCoustomer.Name;
            coustomerEmailShowtextBox.Text = aCoustomer.Email;

            accountNumberShowtextBox.Text = aCoustomer.AnAccount.AccountNumber;
            openingDateShowtextBox.Text = aCoustomer.AnAccount.OpeningDate;

            balancetextBox.Text = aCoustomer.AnAccount.Balance.ToString();
        }
    }
}
