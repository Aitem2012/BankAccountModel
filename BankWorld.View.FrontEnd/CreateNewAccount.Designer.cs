
namespace BankWorld.View.FrontEnd
{
    partial class CreateNewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accountTypeCombo = new System.Windows.Forms.ComboBox();
            this.createNewAccountBtn = new System.Windows.Forms.Button();
            this.openingBalanceForNewAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accountTypeCombo
            // 
            this.accountTypeCombo.FormattingEnabled = true;
            this.accountTypeCombo.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accountTypeCombo.Location = new System.Drawing.Point(71, 83);
            this.accountTypeCombo.Name = "accountTypeCombo";
            this.accountTypeCombo.Size = new System.Drawing.Size(226, 28);
            this.accountTypeCombo.TabIndex = 0;
            this.accountTypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // createNewAccountBtn
            // 
            this.createNewAccountBtn.Location = new System.Drawing.Point(71, 231);
            this.createNewAccountBtn.Name = "createNewAccountBtn";
            this.createNewAccountBtn.Size = new System.Drawing.Size(226, 29);
            this.createNewAccountBtn.TabIndex = 1;
            this.createNewAccountBtn.Text = "Create Account";
            this.createNewAccountBtn.UseVisualStyleBackColor = true;
            this.createNewAccountBtn.Click += new System.EventHandler(this.createNewAccountBtn_Click);
            // 
            // openingBalanceForNewAccount
            // 
            this.openingBalanceForNewAccount.Location = new System.Drawing.Point(71, 150);
            this.openingBalanceForNewAccount.Name = "openingBalanceForNewAccount";
            this.openingBalanceForNewAccount.PlaceholderText = "Opening Balance";
            this.openingBalanceForNewAccount.Size = new System.Drawing.Size(226, 27);
            this.openingBalanceForNewAccount.TabIndex = 2;
            this.openingBalanceForNewAccount.Visible = false;
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 369);
            this.Controls.Add(this.openingBalanceForNewAccount);
            this.Controls.Add(this.createNewAccountBtn);
            this.Controls.Add(this.accountTypeCombo);
            this.Name = "CreateNewAccount";
            this.Text = "CreateNewAccount";
            this.Load += new System.EventHandler(this.CreateNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox accountTypeCombo;
        private System.Windows.Forms.Button createNewAccountBtn;
        private System.Windows.Forms.TextBox openingBalanceForNewAccount;
    }
}