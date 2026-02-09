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
    public partial class loginControl : UserControl
    {
        public event Action<Account>? loginSuccess;
        public event Action? toSignupClicked;
        public loginControl()
        {
            InitializeComponent();
        }

        public void signupButton_Click(object sender, EventArgs e)
        {
            toSignupClicked?.Invoke();
        }

        public Account? verifyAccount(string inputUsername, string inputPassword)
        {
            List<Account> accounts = AccountManager.GetAccounts();

            foreach (Account account in accounts)
            {
                if (account.Username == inputUsername && account.Password == inputPassword)
                {
                    return account;
                }
            }

            return null;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = usernameBox.Text.Trim();
            string inputPassword = passwordBox.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            Account? account = verifyAccount(inputUsername, inputPassword);

            if (account != null)
            {
                MessageBox.Show($"Welcome, {account.DisplayName}!");
                loginSuccess?.Invoke(account);
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
