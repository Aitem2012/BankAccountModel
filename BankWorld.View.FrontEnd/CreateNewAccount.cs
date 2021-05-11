using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankWorld.View.FrontEnd
{
    public partial class CreateNewAccount : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAuthService _authService;
        private readonly IAccountService _accountService;
        
        public CreateNewAccount(ICustomerService customerService, IAuthService authService, IAccountService accountService)
        {
            InitializeComponent();
            _customerService = customerService;
            _accountService = accountService;
            _authService = authService;
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountTypeCombo.SelectedIndex == 0)
            {
                openingBalanceForNewAccount.Show();
            }
            else
            {
                openingBalanceForNewAccount.Hide();
            }
        }

        private void createNewAccountBtn_Click(object sender, EventArgs e)
        {
            var customer = _customerService.GetCustomerByEmail(Login._email);
            var account = _accountService.CreateAccount(customer.CustomerId, accountTypeCombo.Text);
            if (accountTypeCombo.Text == "Savings")
            {

                _accountService.Deposit(account.AccountNumber, Convert.ToDecimal(openingBalanceForNewAccount.Text), "Opening Balance");
            }
        }
    }
}
