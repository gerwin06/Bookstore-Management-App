using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement
{
    public abstract class Account
    {
        private string username;
        private string password;
        private string displayName; 
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public Account(string username, string password, string displayName)
        {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
        }
        public virtual string GetRole()
        {
            return "Generic Account";
        }

        public override string ToString()
        {
            return $"{username}~{password}~{displayName}~{GetRole()}";
        }
    }
    
    public class CustomerAccount : Account
    {
        public Cart? Cart { get; private set; }

        public override string GetRole()
        {
            return "Customer";
        }

        public CustomerAccount(string username, string password, string displayName)
        : base(username, password, displayName)
        {
            Cart = new Cart(username);
        }

    }

    public class AdminAccount : Account
    {
        public override string GetRole()
        {
            return "Admin";
        }

        public AdminAccount(string username, string password, string displayName) : base(username, password, displayName)
        {
        }
    }

    public class IncompleteFieldsException : Exception
    {
        public IncompleteFieldsException() {}
        public IncompleteFieldsException(string message) : base(message) {}
    }
    public static class AccountManager
    {
        public static string accountsFilePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName, "accounts.txt");

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            if (!File.Exists(accountsFilePath))
            {
                MessageBox.Show("accounts.txt file not found.");
                return accounts;
            }

            try
            {
                foreach (string currentLine in File.ReadAllLines(accountsFilePath))
                {
                    string[] parts = currentLine.Split('~');

                    if (parts.Length == 4)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        string display = parts[2];
                        string role = parts[3];

                        Account newAcc;

                        if (role == "Admin")
                            newAcc = new AdminAccount(username, password, display);
                        else
                            newAcc = new CustomerAccount(username, password, display);

                        accounts.Add(newAcc);
                    }
                    else
                    {
                        throw new IncompleteFieldsException("Incomplete fields detected, line: " + currentLine);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return accounts;
        }

        public static void RegisterAccount(Account account)
        {
            if (!File.Exists(accountsFilePath))
            {
                MessageBox.Show("accounts.txt file not found.");
                return;
            }

            List<Account> accounts = GetAccounts();
            accounts.Add(account);

            try
            {
                File.WriteAllLines(accountsFilePath, accounts.Select(a => a.ToString()));
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
