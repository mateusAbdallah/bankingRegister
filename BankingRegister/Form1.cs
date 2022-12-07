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
            textBox3.Text = textBoxName.Text;
            textBox3.Visible = true;

            textBox4.Text = textBoxAccountNumber.Text;
            textBox4.Visible = true;

            textBox5.Text = (textBoxOriginalDeposit.Text);
            textBox5.Visible = true;


        }
    }
}
