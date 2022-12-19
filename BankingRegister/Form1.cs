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

            while(int.TryParse(textBoxAccountNumber.Text, out numberAccount) == false)
            {
                MessageBox.Show("Numeric value should be entered for account number");
                textBoxAccountNumber.Text = "0";
                textBoxAccountNumber.Focus();
            }
            if(double.TryParse(textBoxOriginalDeposit.Text, out originalDeposit) == false)
            {
                MessageBox.Show("Numeric value should be entered for deposit");
                textBoxOriginalDeposit.Text = "0";
                textBoxOriginalDeposit.Focus();
            }
            name = textBoxName.Text.Split(' ');
            if(name.Length < 2)
            {
                textBoxName.Text = "Please enter full name";
                textBoxName.Focus();
            }
            else
            {
                if(numberAccount > 0)
                {
                    Customer customer = new Customer(name[0], name[1], numberAccount, originalDeposit);
                    
                }
            }
            //full name
            //var name = textBoxName.Text;
            //var fullName = name.Split(' ');
            //string firstName = fullName[0];
            //string lastName = fullName[1];

            //account number
            //int amount = 0;
            //while (int.TryParse(textBoxAccountNumber.Text, out amount) == false)
            //{
            //    MessageBox.Show("Invalid input, enter value again");
            //    textBoxAccountNumber.Focus();
            //}

            //original deposit
            //double originalDeposit = 0.0;
            //while (double.TryParse(textBoxOriginalDeposit.Text, out originalDeposit) == false)
            //{
            //    MessageBox.Show("Invalid input, enter value again");
            //    textBoxAccountNumber.Focus();
            //}

            //textBox3.Text = obj.FirstName + " " + obj.LastName;
            //textBox3.Text = textBoxName.Text;
            //textBox3.Visible = true;

            //int x;
            //if(int.TryParse(textBox4.Text, out x) == false)
            //{
            //    MessageBox.Show("invalid input, re-enter a value again");
            //    textBox4.Focus();
            //}


            //textBox3.Text = textBoxName.Text;
            //textBox3.Visible = true;

            //textBox4.Text = textBoxAccountNumber.Text;
            //textBox4.Visible = true;

            //textBox5.Text = (textBoxOriginalDeposit.Text);
            //textBox5.Visible = true;


        }
    }
}
