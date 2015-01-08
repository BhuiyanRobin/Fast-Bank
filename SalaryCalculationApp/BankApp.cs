using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationApp
{
    public partial class BankApp : Form
    {
        public BankApp()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
       
        private void saveButton_Click(object sender, EventArgs e)
        {
            aCustomer=new Customer();
            Account account=new Account();
            account.AccountNumebr = accountNumberEntryTextBox.Text;
            account.OpeningDate = dateEntryTextBox.Text;


            aCustomer.Email = emailEntryTextBox.Text;
            aCustomer.Name = nameEntryTextBox.Text;

            aCustomer.AAccount = account;
            MessageBox.Show("Account Created");

        }
        private void withdrawnButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AAccount.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AAccount.Deposite(amount);
            MessageBox.Show("Deposited");
        }

        private void showMeDetailsButton_Click_1(object sender, EventArgs e)
        {
            nameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountNumberDisplayTextBox.Text = aCustomer.AAccount.AccountNumebr;
            dateDisplayTextBox.Text = aCustomer.AAccount.OpeningDate;
            balanceDisplayTextBox.Text = aCustomer.AAccount.Blance.ToString();
        }


    }
}
