using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingRegister
{
    public partial class Form1_BankingRegister : Form
    {
        private Customer customer;

        public Form1_BankingRegister()
        {
            InitializeComponent();
        }

        private void Form1_BankingRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thanks for using the app");
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

            int numberAccount = 0;
            string[] name = new string[2];
            double originalDeposit = 0.0;

        
            if(int.TryParse(textBoxAccountNumber.Text, out numberAccount) == false)
            {
                MessageBox.Show("Numeric value should be entered for account number");
                textBoxAccountNumber.Focus();
            }
            else
            {
                if(numberAccount <= 0 )
                {
                    textBoxAccountNumber.Text = "Value greater than 0";
                    textBoxAccountNumber.Focus();
                }
            }
            if(double.TryParse(textBoxOriginalDeposit.Text, out originalDeposit) == false)
            {
                MessageBox.Show("Numeric value should be entered for deposit");
                textBoxOriginalDeposit.Text = "Value greater than 0";
                textBoxOriginalDeposit.Focus();
            }
            else
            {
                if (originalDeposit <= 0)
                {
                    textBoxOriginalDeposit.Text = "Value greater than 0";
                    textBoxOriginalDeposit.Focus();
                }
            }

            name = textBoxName.Text.Split(' ');
            if(name.Length < 2)
            {
                MessageBox.Show("Enter full name");
                //textBoxName.Text = "Please enter full name";
                textBoxName.Focus();                
            }
            
            if (numberAccount > 0 && originalDeposit > 0 && name.Length >= 2)
            {
               label_deposit.Visible = true;
               txtDeposit.Visible = true;
               label_withdraw.Visible = true;
               txtWithdraw.Visible = true;
               button1.Visible = true;
            }

            
            if(name.Length > 1)
            {
                customer = new Customer(name[0], name[1], numberAccount, originalDeposit);
            }
                

        }       

       

        private void button1_Click(object sender, EventArgs e)
        {

            double amountDeposit;
            
            if (double.TryParse(txtDeposit.Text, out amountDeposit) == false && !string.IsNullOrWhiteSpace(txtDeposit.Text))
            {
                MessageBox.Show("Enter a number");
                txtDeposit.Text = "Value greater than 0";
                txtDeposit.Focus();
            }
            else
            {
                if (amountDeposit < 0)
                {
                    txtDeposit.Text = "Enter a number greater than 0";
                    txtDeposit.Focus();
                }
            }

            double amountWithdraw;

            if (double.TryParse(txtWithdraw.Text, out amountWithdraw) == false && !string.IsNullOrWhiteSpace(txtWithdraw.Text))
            {
                MessageBox.Show("Enter a number");
                txtWithdraw.Text = "Value greater than 0";
                txtWithdraw.Focus();
            }
            else
            {
                if (amountWithdraw < 0)
                {
                    txtWithdraw.Text = "Enter a number greater than 0";
                    txtWithdraw.Focus();
                }
            }
            
            if(amountDeposit > 0)
            {
                customer.Deposit(amountDeposit);
                updateBalance();
            }

            if (amountWithdraw > 0)
            {
                customer.Withdraw(amountWithdraw);
                updateBalance();
            }
        }

        private void updateBalance()
        {
            textBoxOriginalDeposit.Text = customer.AccountBalance.ToString();
        }

    }
}
