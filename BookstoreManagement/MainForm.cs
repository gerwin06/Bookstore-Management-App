namespace BookstoreManagement
{
    public partial class MainForm : Form
    {
        private customerControl customerPage;
        private loginControl loginPage;
        private signupControl signUpPage;
        private viewCart viewCartPage;
        private adminControl adminPage;

        public MainForm()
        {
            InitializeComponent();

            loginPage = new loginControl();
            signUpPage = new signupControl();
            customerPage = new customerControl();
            viewCartPage = new viewCart();
            adminPage = new adminControl();

            panelContainer.Controls.Add(loginPage);
            panelContainer.Controls.Add(signUpPage);
            panelContainer.Controls.Add(customerPage);
            panelContainer.Controls.Add(viewCartPage);
            panelContainer.Controls.Add(adminPage);

            foreach (Control c in panelContainer.Controls)
            {
                c.Dock = DockStyle.Fill;
                c.Visible = false;
            }

            loginPage.toSignupClicked += () => ShowControl(signUpPage);
            signUpPage.toLoginClicked += () => ShowControl(loginPage);
            loginPage.loginSuccess += OnLoginSuccess;
            customerPage.clickedCart += () => ShowControl(viewCartPage);
            customerPage.logoutClicked += OnLogout;
            adminPage.logoutClicked += OnLogout;
            viewCartPage.toCustomerPageClicked += () => ShowControl(customerPage);

            ShowControl(loginPage);
        }

        private void OnLogout()
        {
            ShowControl(loginPage);
        }

        private void OnLoginSuccess(Account user)
        {
            if (user is AdminAccount)
            {
                ShowControl(adminPage);
            }
            else if (user is CustomerAccount customer)
            {
                customerPage.CurrentAccount = customer;
                viewCartPage.CurrentAccount = customer;
                ShowControl(customerPage);
            }
        }

        private void ShowControl(UserControl control)
        {
            foreach (Control c in panelContainer.Controls)
                c.Visible = false;

            control.Visible = true;
            control.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}