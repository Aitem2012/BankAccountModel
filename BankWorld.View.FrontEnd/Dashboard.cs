using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace BankWorld.View.FrontEnd
{
    public partial class Dashboard : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAuthService _authService;
        private readonly IAccountService _accountService;
        
        public Dashboard(ICustomerService customerService, IAuthService auth, IAccountService accountService)
        {
            InitializeComponent();
            _customerService = customerService;
            _authService = auth;
            _accountService = accountService;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            withdrawPanel.Hide();
            transferPanel.Hide();
            depositPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            depositPanel.Hide();
            transferPanel.Hide();
            statementOfAccountPanel.Hide();
            withdrawPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdrawPanel.Hide();
            depositPanel.Hide();
            statementOfAccountPanel.Hide();
            transferPanel.Show();
        }

        private void statementOfAccountBtn_Click(object sender, EventArgs e)
        {
            withdrawPanel.Hide();
            depositPanel.Hide();
            transferPanel.Hide();

            statementOfAccountPanel.Show();
            var transactions = _accountService.GetTransactionByAccountNumber(accountComboBox.Text);
            statementOfAccountTable.DataSource = transactions.Select(s => new
            {
                Date = Convert.ToDateTime(s.DateOfTransaction).ToString(),
                Amount = s.Amount,
                Note = s.Note
            }).ToList();

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Login(_customerService, _authService, _accountService).Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomerByEmail(Login._email);
            var account = _accountService.GetAccountDetails(customer.CustomerId);
           
            accountComboBox.Text = account.AccountNumber;
            accountTypeLabel.Text = account.AccType;
            balanceLabel.Text = "NGN " + _accountService.GetBalance(account.AccountId);
            accountNameLabel.Text = customer.Customer.FirstName + " " + customer.Customer.LastName;
        }

        private void depositToAccount_Click(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomerByEmail(Login._email);
            var account = _accountService.GetAccountDetails(customer.CustomerId);
            var amount = Decimal.TryParse(depositAmountBox.Text, out var amt);
            _accountService.Deposit(account.AccountId, amt, depositNoteBox.Text);
            Thread.Sleep(2000);
            balanceLabel.Text = "NGN " + _accountService.GetBalance(account.AccountId);
            depositAmountBox.Clear(); depositNoteBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomerByEmail(Login._email);
            var account = _accountService.GetAccountDetails(customer.CustomerId);
            var amount = Decimal.TryParse(withdrawAmountBox.Text, out var amnt);
            var res = _accountService.Withdraw(account.AccountId, amnt, withdrawNoteBox.Text);
            Thread.Sleep(2000);
            MessageBox.Show(res[0]);
            balanceLabel.Text = "NGN " + _accountService.GetBalance(account.AccountId);
            withdrawNoteBox.Clear(); withdrawAmountBox.Clear();

        }

        private void statementOfAccountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void newAccountBtn_Click(object sender, EventArgs e)
        {
        
            
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transferAmountBtn_Click(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomerByEmail(Login._email);
            var account = _accountService.GetAccountDetails(customer.CustomerId);
            var transfer = _accountService.Transfer(accountComboBox.Text, receiverAccountNumberBox.Text, Convert.ToDecimal(transferAmountBox.Text), transferNoteBox.Text);
            MessageBox.Show(transfer[0], "Response");
            balanceLabel.Text = "NGN " + _accountService.GetBalance(account.AccountId);
            receiverAccountNumberBox.Clear();transferAmountBox.Clear();  transferNoteBox.Clear();
        }
    }
}
