using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagement
{
    public partial class signupControl : UserControl
    {
        public event Action? toLoginClicked;
        public signupControl()
        {
            InitializeComponent();
        }

        public void signupControl_Load(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string displayName = displayNameBox.Text;
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string confirmpass = confirmPassBox.Text;

            if (new[] { displayNameBox, usernameBox, passwordBox, confirmPassBox }.Any(b => string.IsNullOrEmpty(b.Text)))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            List<Account> accountList = AccountManager.GetAccounts();

            if (accountList.Any(acc => acc.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username already exists!");
                return;
            }

            Account newAccount = new CustomerAccount(username, password, displayName);
            AccountManager.RegisterAccount(newAccount);

            MessageBox.Show("Account created successfully! Returning to login page...");

            toLoginClicked?.Invoke();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toLoginButton_Click(object sender, EventArgs e)
        {
            toLoginClicked?.Invoke();
        }
    }
}
