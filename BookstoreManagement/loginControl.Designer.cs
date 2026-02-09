namespace BookstoreManagement
{
    partial class loginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            toSignupButton = new Button();
            loginButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(passwordBox, 0, 1);
            tableLayoutPanel1.Controls.Add(usernameBox, 0, 0);
            tableLayoutPanel1.Location = new Point(476, 194);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(205, 69);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // passwordBox
            // 
            passwordBox.AcceptsReturn = true;
            passwordBox.Dock = DockStyle.Fill;
            passwordBox.Location = new Point(3, 37);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Enter Password";
            passwordBox.Size = new Size(199, 23);
            passwordBox.TabIndex = 3;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            usernameBox.AcceptsReturn = true;
            usernameBox.Dock = DockStyle.Fill;
            usernameBox.Location = new Point(3, 3);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter Username";
            usernameBox.Size = new Size(199, 23);
            usernameBox.TabIndex = 2;
            // 
            // toSignupButton
            // 
            toSignupButton.Anchor = AnchorStyles.Bottom;
            toSignupButton.Location = new Point(474, 334);
            toSignupButton.Name = "toSignupButton";
            toSignupButton.Size = new Size(208, 42);
            toSignupButton.TabIndex = 7;
            toSignupButton.Text = "Go to Signup";
            toSignupButton.UseVisualStyleBackColor = true;
            toSignupButton.Click += signupButton_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Bottom;
            loginButton.Location = new Point(474, 286);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(208, 42);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toSignupButton);
            Controls.Add(loginButton);
            Name = "loginControl";
            Size = new Size(1157, 609);
            Load += loginControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button toSignupButton;
        private Button loginButton;
    }
}
