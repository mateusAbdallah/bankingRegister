namespace BankingRegister
{
    partial class Form1_BankingRegister
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_titleBankingRegister = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_accountNumber = new System.Windows.Forms.Label();
            this.label_originalDeposit = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxOriginalDeposit = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.label_deposit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_withdraw = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_titleBankingRegister
            // 
            this.label1_titleBankingRegister.AutoSize = true;
            this.label1_titleBankingRegister.BackColor = System.Drawing.SystemColors.Menu;
            this.label1_titleBankingRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_titleBankingRegister.Location = new System.Drawing.Point(35, 21);
            this.label1_titleBankingRegister.Name = "label1_titleBankingRegister";
            this.label1_titleBankingRegister.Size = new System.Drawing.Size(147, 20);
            this.label1_titleBankingRegister.TabIndex = 0;
            this.label1_titleBankingRegister.Text = "Banking Register";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(36, 64);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            // 
            // label_accountNumber
            // 
            this.label_accountNumber.AutoSize = true;
            this.label_accountNumber.Location = new System.Drawing.Point(36, 116);
            this.label_accountNumber.Name = "label_accountNumber";
            this.label_accountNumber.Size = new System.Drawing.Size(90, 13);
            this.label_accountNumber.TabIndex = 2;
            this.label_accountNumber.Text = "Account Number:";
            // 
            // label_originalDeposit
            // 
            this.label_originalDeposit.AutoSize = true;
            this.label_originalDeposit.Location = new System.Drawing.Point(36, 179);
            this.label_originalDeposit.Name = "label_originalDeposit";
            this.label_originalDeposit.Size = new System.Drawing.Size(84, 13);
            this.label_originalDeposit.TabIndex = 3;
            this.label_originalDeposit.Text = "Original Deposit;";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(202, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(202, 116);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountNumber.TabIndex = 5;
            // 
            // textBoxOriginalDeposit
            // 
            this.textBoxOriginalDeposit.Location = new System.Drawing.Point(202, 179);
            this.textBoxOriginalDeposit.Name = "textBoxOriginalDeposit";
            this.textBoxOriginalDeposit.Size = new System.Drawing.Size(100, 20);
            this.textBoxOriginalDeposit.TabIndex = 6;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(80, 244);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // label_deposit
            // 
            this.label_deposit.AutoSize = true;
            this.label_deposit.Location = new System.Drawing.Point(460, 64);
            this.label_deposit.Name = "label_deposit";
            this.label_deposit.Size = new System.Drawing.Size(43, 13);
            this.label_deposit.TabIndex = 8;
            this.label_deposit.Text = "Deposit";
            this.label_deposit.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // label_withdraw
            // 
            this.label_withdraw.AutoSize = true;
            this.label_withdraw.Location = new System.Drawing.Point(619, 64);
            this.label_withdraw.Name = "label_withdraw";
            this.label_withdraw.Size = new System.Drawing.Size(52, 13);
            this.label_withdraw.TabIndex = 10;
            this.label_withdraw.Text = "Withdraw";
            this.label_withdraw.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(594, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Form1_BankingRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_withdraw);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_deposit);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.textBoxOriginalDeposit);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_originalDeposit);
            this.Controls.Add(this.label_accountNumber);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1_titleBankingRegister);
            this.Name = "Form1_BankingRegister";
            this.Text = "Banking Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_BankingRegister_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_titleBankingRegister;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_accountNumber;
        private System.Windows.Forms.Label label_originalDeposit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxOriginalDeposit;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label label_deposit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_withdraw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

