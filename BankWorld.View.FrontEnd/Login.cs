using Core.Interfaces;
using Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace BankWorld.View.FrontEnd
{
    public partial class Login : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IAuthService _authService;
        private readonly IAccountService _accountService;
        public static string _email;
        public Login(ICustomerService customerService, IAuthService authService, IAccountService accountService)
        {
            InitializeComponent();
            _customerService = customerService;
            _accountService = accountService;
            _authService = authService;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Hide();
            accountPanel.Show();
        }

        private void accountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check the account type selected to require opening balance
            if (accountType.SelectedIndex == 0)
            {
                openingBalance.Show();
            }
            else
            {
                openingBalance.Hide();
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Generate a hashed password from the input password
            var password = Utilities.Utilities.GenerateHash(createAccountPasswordBox.Text);
            var email = Utilities.Utilities.ValidateEmail(createAccountEmailBox.Text);

            if (email)
            {
                var emailExist = _authService.UserExist(createAccountEmailBox.Text);
                if (emailExist)
                {
                    MessageBox.Show("Email Exist","Email Exist", MessageBoxButtons.RetryCancel);
                }
                else
                {

                    //Create a customer details
                    var customer = _customerService.RegisterCustomer(Utilities.Utilities.FirstCharacterToUpper(Utilities.Utilities.RemoveDigitFromStart(firstnameBox.Text)),
                        Utilities.Utilities.FirstCharacterToUpper(Utilities.Utilities.RemoveDigitFromStart(lastnameBox.Text)));
                    //Create an account
                    var account = _accountService.CreateAccount(customer.CustomerId, accountType.Text);
                    if (accountType.Text == "Savings")
                    {

                        _accountService.Deposit(account.AccountNumber, Convert.ToDecimal(openingBalance.Text), "Opening Balance");
                    }

                    //Register for authentication
                    var auth = _authService.CreateUser(createAccountEmailBox.Text, password[0], password[1], customer.CustomerId);

                    MessageBox.Show("Account Created Successfully", account.AccountNumber);
                    var bal = _accountService.GetBalance(account.AccountNumber).ToString();
                    MessageBox.Show(bal);
                    firstnameBox.Clear(); lastnameBox.Clear(); createAccountEmailBox.Clear(); createAccountPasswordBox.Clear();
                    accountType.Text = ""; openingBalance.Clear();
                    accountPanel.Hide();
                    loginPanel.Show();

                }
            }
            else
            {
                MessageBox.Show("You have entered an invalid email");
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {

            //Check that email and password is not null or empty
            if (String.IsNullOrEmpty(emailBox.Text) || String.IsNullOrEmpty(passwordBox.Text))
            {
                MessageBox.Show("Email and Password can not be Empty");
            }

            else
            {
                //validate email address
                var email = Utilities.Utilities.ValidateEmail(emailBox.Text);
                if (email)
                {
                    var emailIsValid = _authService.UserExist(emailBox.Text);
                    if (emailIsValid)
                    {
                        var user = _authService.UserIsValid(emailBox.Text);
                        var passwordIsCorrect = Utilities.Utilities.CompareHash(Convert.FromBase64String(user.PasswordHash), Convert.FromBase64String(user.PasswordSalt), passwordBox.Text);
                        if (passwordIsCorrect)
                        {
                            _email = emailBox.Text;
                            MessageBox.Show("Successful");
                            this.Hide();
                            new Dashboard(_customerService, _authService, _accountService).Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                            passwordBox.Clear(); emailBox.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
