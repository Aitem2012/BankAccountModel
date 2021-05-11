
namespace BankWorld.View.FrontEnd
{
    partial class Dashboard
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
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.statementOfAccountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.depositToAccount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.depositNoteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depositAmountBox = new System.Windows.Forms.TextBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.withdrawNoteBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.withdrawAmountBox = new System.Windows.Forms.TextBox();
            this.transferPanel = new System.Windows.Forms.Panel();
            this.statementOfAccountPanel = new System.Windows.Forms.Panel();
            this.statementOfAccountTable = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.transferNoteBox = new System.Windows.Forms.TextBox();
            this.transferAmountBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.receiverAccountNumberBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.transferAmountBox = new System.Windows.Forms.TextBox();
            this.depositPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.transferPanel.SuspendLayout();
            this.statementOfAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statementOfAccountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.depositBtn.ForeColor = System.Drawing.Color.Coral;
            this.depositBtn.Location = new System.Drawing.Point(29, 102);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(195, 50);
            this.depositBtn.TabIndex = 0;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.withdrawBtn.ForeColor = System.Drawing.Color.Coral;
            this.withdrawBtn.Location = new System.Drawing.Point(29, 151);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(195, 50);
            this.withdrawBtn.TabIndex = 1;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.transferBtn.ForeColor = System.Drawing.Color.Coral;
            this.transferBtn.Location = new System.Drawing.Point(29, 197);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(195, 50);
            this.transferBtn.TabIndex = 2;
            this.transferBtn.Text = "TRANSFER";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // statementOfAccountBtn
            // 
            this.statementOfAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.statementOfAccountBtn.ForeColor = System.Drawing.Color.Coral;
            this.statementOfAccountBtn.Location = new System.Drawing.Point(29, 246);
            this.statementOfAccountBtn.Name = "statementOfAccountBtn";
            this.statementOfAccountBtn.Size = new System.Drawing.Size(195, 50);
            this.statementOfAccountBtn.TabIndex = 3;
            this.statementOfAccountBtn.Text = "STATE OF ACCOUNT";
            this.statementOfAccountBtn.UseVisualStyleBackColor = false;
            this.statementOfAccountBtn.Click += new System.EventHandler(this.statementOfAccountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "DASHBOARD";
            // 
            // depositPanel
            // 
            this.depositPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.depositPanel.Controls.Add(this.depositToAccount);
            this.depositPanel.Controls.Add(this.label6);
            this.depositPanel.Controls.Add(this.depositNoteBox);
            this.depositPanel.Controls.Add(this.label5);
            this.depositPanel.Controls.Add(this.depositAmountBox);
            this.depositPanel.Location = new System.Drawing.Point(294, 101);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(434, 424);
            this.depositPanel.TabIndex = 5;
            // 
            // depositToAccount
            // 
            this.depositToAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.depositToAccount.ForeColor = System.Drawing.Color.Coral;
            this.depositToAccount.Location = new System.Drawing.Point(98, 236);
            this.depositToAccount.Name = "depositToAccount";
            this.depositToAccount.Size = new System.Drawing.Size(234, 50);
            this.depositToAccount.TabIndex = 13;
            this.depositToAccount.Text = "DEPOSIT";
            this.depositToAccount.UseVisualStyleBackColor = false;
            this.depositToAccount.Click += new System.EventHandler(this.depositToAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(98, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Note";
            // 
            // depositNoteBox
            // 
            this.depositNoteBox.Location = new System.Drawing.Point(98, 167);
            this.depositNoteBox.Name = "depositNoteBox";
            this.depositNoteBox.PlaceholderText = "e.g Food money";
            this.depositNoteBox.Size = new System.Drawing.Size(234, 27);
            this.depositNoteBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(98, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount";
            // 
            // depositAmountBox
            // 
            this.depositAmountBox.Location = new System.Drawing.Point(98, 61);
            this.depositAmountBox.Name = "depositAmountBox";
            this.depositAmountBox.PlaceholderText = "e.g 1000";
            this.depositAmountBox.Size = new System.Drawing.Size(234, 27);
            this.depositAmountBox.TabIndex = 0;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(745, 95);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(228, 28);
            this.accountComboBox.TabIndex = 6;
            this.accountComboBox.SelectedIndexChanged += new System.EventHandler(this.accountComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Name";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(879, 183);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(50, 20);
            this.accountNameLabel.TabIndex = 8;
            this.accountNameLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Balance";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(879, 232);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(50, 20);
            this.balanceLabel.TabIndex = 10;
            this.balanceLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(879, 291);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.accountTypeLabel.TabIndex = 12;
            this.accountTypeLabel.Text = "label5";
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.withdrawPanel.Controls.Add(this.button1);
            this.withdrawPanel.Controls.Add(this.label7);
            this.withdrawPanel.Controls.Add(this.withdrawNoteBox);
            this.withdrawPanel.Controls.Add(this.label8);
            this.withdrawPanel.Controls.Add(this.withdrawAmountBox);
            this.withdrawPanel.Location = new System.Drawing.Point(294, 96);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(434, 424);
            this.withdrawPanel.TabIndex = 14;
            this.withdrawPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(98, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "WITHDRAW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(98, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note";
            // 
            // withdrawNoteBox
            // 
            this.withdrawNoteBox.Location = new System.Drawing.Point(98, 167);
            this.withdrawNoteBox.Name = "withdrawNoteBox";
            this.withdrawNoteBox.PlaceholderText = "e.g Food money";
            this.withdrawNoteBox.Size = new System.Drawing.Size(234, 27);
            this.withdrawNoteBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(98, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount";
            // 
            // withdrawAmountBox
            // 
            this.withdrawAmountBox.Location = new System.Drawing.Point(98, 61);
            this.withdrawAmountBox.Name = "withdrawAmountBox";
            this.withdrawAmountBox.PlaceholderText = "e.g 1000";
            this.withdrawAmountBox.Size = new System.Drawing.Size(234, 27);
            this.withdrawAmountBox.TabIndex = 0;
            // 
            // transferPanel
            // 
            this.transferPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.transferPanel.Controls.Add(this.label11);
            this.transferPanel.Controls.Add(this.transferNoteBox);
            this.transferPanel.Controls.Add(this.transferAmountBtn);
            this.transferPanel.Controls.Add(this.label9);
            this.transferPanel.Controls.Add(this.receiverAccountNumberBox);
            this.transferPanel.Controls.Add(this.label10);
            this.transferPanel.Controls.Add(this.transferAmountBox);
            this.transferPanel.Location = new System.Drawing.Point(294, 96);
            this.transferPanel.Name = "transferPanel";
            this.transferPanel.Size = new System.Drawing.Size(434, 424);
            this.transferPanel.TabIndex = 15;
            this.transferPanel.Visible = false;
            // 
            // statementOfAccountPanel
            // 
            this.statementOfAccountPanel.Controls.Add(this.statementOfAccountTable);
            this.statementOfAccountPanel.Location = new System.Drawing.Point(295, 93);
            this.statementOfAccountPanel.Name = "statementOfAccountPanel";
            this.statementOfAccountPanel.Size = new System.Drawing.Size(433, 427);
            this.statementOfAccountPanel.TabIndex = 16;
            // 
            // statementOfAccountTable
            // 
            this.statementOfAccountTable.AllowUserToAddRows = false;
            this.statementOfAccountTable.AllowUserToDeleteRows = false;
            this.statementOfAccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statementOfAccountTable.Location = new System.Drawing.Point(14, 22);
            this.statementOfAccountTable.Name = "statementOfAccountTable";
            this.statementOfAccountTable.ReadOnly = true;
            this.statementOfAccountTable.RowHeadersWidth = 51;
            this.statementOfAccountTable.RowTemplate.Height = 29;
            this.statementOfAccountTable.Size = new System.Drawing.Size(402, 380);
            this.statementOfAccountTable.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(98, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Note";
            // 
            // transferNoteBox
            // 
            this.transferNoteBox.Location = new System.Drawing.Point(98, 258);
            this.transferNoteBox.Name = "transferNoteBox";
            this.transferNoteBox.PlaceholderText = "e.g Food money";
            this.transferNoteBox.Size = new System.Drawing.Size(234, 27);
            this.transferNoteBox.TabIndex = 14;
            // 
            // transferAmountBtn
            // 
            this.transferAmountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(87)))));
            this.transferAmountBtn.ForeColor = System.Drawing.Color.Coral;
            this.transferAmountBtn.Location = new System.Drawing.Point(98, 313);
            this.transferAmountBtn.Name = "transferAmountBtn";
            this.transferAmountBtn.Size = new System.Drawing.Size(234, 50);
            this.transferAmountBtn.TabIndex = 13;
            this.transferAmountBtn.Text = "TRANSFER";
            this.transferAmountBtn.UseVisualStyleBackColor = false;
            this.transferAmountBtn.Click += new System.EventHandler(this.transferAmountBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(98, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Receiver Account Number";
            // 
            // receiverAccountNumberBox
            // 
            this.receiverAccountNumberBox.Location = new System.Drawing.Point(98, 167);
            this.receiverAccountNumberBox.Name = "receiverAccountNumberBox";
            this.receiverAccountNumberBox.PlaceholderText = "e.g Food money";
            this.receiverAccountNumberBox.Size = new System.Drawing.Size(234, 27);
            this.receiverAccountNumberBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(98, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Amount";
            // 
            // transferAmountBox
            // 
            this.transferAmountBox.Location = new System.Drawing.Point(98, 61);
            this.transferAmountBox.Name = "transferAmountBox";
            this.transferAmountBox.PlaceholderText = "e.g 1000";
            this.transferAmountBox.Size = new System.Drawing.Size(234, 27);
            this.transferAmountBox.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1029, 605);
            this.Controls.Add(this.statementOfAccountPanel);
            this.Controls.Add(this.transferPanel);
            this.Controls.Add(this.withdrawPanel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statementOfAccountBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.transferPanel.ResumeLayout(false);
            this.transferPanel.PerformLayout();
            this.statementOfAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statementOfAccountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button statementOfAccountBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button depositToAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox depositNoteBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depositAmountBox;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox withdrawNoteBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox withdrawAmountBox;
        private System.Windows.Forms.Panel transferPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox transferNoteBox;
        private System.Windows.Forms.Button transferAmountBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox receiverAccountNumberBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transferAmountBox;
        private System.Windows.Forms.Panel statementOfAccountPanel;
        private System.Windows.Forms.DataGridView statementOfAccountTable;
    }
}