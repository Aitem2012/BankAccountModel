
namespace BankWorld.View.FrontEnd
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.openingBalance = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.ComboBox();
            this.createAccountPasswordBox = new System.Windows.Forms.TextBox();
            this.createAccountEmailBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailBox.Location = new System.Drawing.Point(45, 73);
            this.emailBox.Name = "emailBox";
            this.emailBox.PlaceholderText = "  e.g aitem@aitem.com";
            this.emailBox.Size = new System.Drawing.Size(258, 34);
            this.emailBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(45, 145);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "  password";
            this.passwordBox.Size = new System.Drawing.Size(258, 34);
            this.passwordBox.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(45, 211);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(258, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Let Me In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.emailBox);
            this.loginPanel.Location = new System.Drawing.Point(125, 47);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(345, 353);
            this.loginPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account? Click";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(249, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.accountPanel.Controls.Add(this.pictureBox1);
            this.accountPanel.Controls.Add(this.createAccountBtn);
            this.accountPanel.Controls.Add(this.openingBalance);
            this.accountPanel.Controls.Add(this.accountType);
            this.accountPanel.Controls.Add(this.createAccountPasswordBox);
            this.accountPanel.Controls.Add(this.createAccountEmailBox);
            this.accountPanel.Controls.Add(this.lastnameBox);
            this.accountPanel.Controls.Add(this.firstnameBox);
            this.accountPanel.Location = new System.Drawing.Point(44, 47);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(528, 380);
            this.accountPanel.TabIndex = 5;
            this.accountPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(291, 228);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(196, 29);
            this.createAccountBtn.TabIndex = 6;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // openingBalance
            // 
            this.openingBalance.Location = new System.Drawing.Point(291, 86);
            this.openingBalance.Name = "openingBalance";
            this.openingBalance.PlaceholderText = "Opening Balance e.g 1000";
            this.openingBalance.Size = new System.Drawing.Size(196, 27);
            this.openingBalance.TabIndex = 5;
            this.openingBalance.Visible = false;
            // 
            // accountType
            // 
            this.accountType.FormattingEnabled = true;
            this.accountType.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.accountType.Location = new System.Drawing.Point(291, 23);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(196, 28);
            this.accountType.TabIndex = 4;
            this.accountType.Text = "Account Type";
            this.accountType.SelectedIndexChanged += new System.EventHandler(this.accountType_SelectedIndexChanged);
            // 
            // createAccountPasswordBox
            // 
            this.createAccountPasswordBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountPasswordBox.Location = new System.Drawing.Point(19, 230);
            this.createAccountPasswordBox.Name = "createAccountPasswordBox";
            this.createAccountPasswordBox.PasswordChar = '*';
            this.createAccountPasswordBox.PlaceholderText = "Password";
            this.createAccountPasswordBox.Size = new System.Drawing.Size(230, 27);
            this.createAccountPasswordBox.TabIndex = 3;
            // 
            // createAccountEmailBox
            // 
            this.createAccountEmailBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccountEmailBox.Location = new System.Drawing.Point(19, 159);
            this.createAccountEmailBox.Name = "createAccountEmailBox";
            this.createAccountEmailBox.PlaceholderText = "Email e.g abc@123.com";
            this.createAccountEmailBox.Size = new System.Drawing.Size(230, 27);
            this.createAccountEmailBox.TabIndex = 2;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameBox.Location = new System.Drawing.Point(19, 86);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.PlaceholderText = "Last Name e.g Grandy";
            this.lastnameBox.Size = new System.Drawing.Size(230, 27);
            this.lastnameBox.TabIndex = 1;
            // 
            // firstnameBox
            // 
            this.firstnameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameBox.Location = new System.Drawing.Point(19, 23);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.PlaceholderText = "First Name  e.g Solomon";
            this.firstnameBox.Size = new System.Drawing.Size(230, 27);
            this.firstnameBox.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(624, 478);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox createAccountPasswordBox;
        private System.Windows.Forms.TextBox createAccountEmailBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox openingBalance;
        private System.Windows.Forms.ComboBox accountType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createAccountBtn;
        public System.Windows.Forms.Panel accountPanel;
    }
}