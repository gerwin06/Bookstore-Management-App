namespace BookstoreManagement
{
    partial class signupControl
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
            confirmPassBox = new TextBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            displayNameBox = new TextBox();
            toLoginButton = new Button();
            signupButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(confirmPassBox, 0, 3);
            tableLayoutPanel1.Controls.Add(usernameBox, 0, 1);
            tableLayoutPanel1.Controls.Add(passwordBox, 0, 2);
            tableLayoutPanel1.Controls.Add(displayNameBox, 0, 0);
            tableLayoutPanel1.Location = new Point(476, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(205, 177);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // confirmPassBox
            // 
            confirmPassBox.AcceptsReturn = true;
            confirmPassBox.Dock = DockStyle.Fill;
            confirmPassBox.Location = new Point(3, 129);
            confirmPassBox.Name = "confirmPassBox";
            confirmPassBox.PasswordChar = '*';
            confirmPassBox.PlaceholderText = "Confirm password";
            confirmPassBox.Size = new Size(199, 23);
            confirmPassBox.TabIndex = 6;
            confirmPassBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            usernameBox.AcceptsReturn = true;
            usernameBox.Dock = DockStyle.Fill;
            usernameBox.Location = new Point(3, 43);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter username";
            usernameBox.Size = new Size(199, 23);
            usernameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            passwordBox.AcceptsReturn = true;
            passwordBox.Dock = DockStyle.Fill;
            passwordBox.Location = new Point(3, 83);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Enter password";
            passwordBox.Size = new Size(199, 23);
            passwordBox.TabIndex = 4;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // displayNameBox
            // 
            displayNameBox.AcceptsReturn = true;
            displayNameBox.Dock = DockStyle.Fill;
            displayNameBox.Location = new Point(3, 3);
            displayNameBox.Name = "displayNameBox";
            displayNameBox.PlaceholderText = "Enter display name";
            displayNameBox.Size = new Size(199, 23);
            displayNameBox.TabIndex = 2;
            displayNameBox.TextChanged += usernameBox_TextChanged;
            // 
            // toLoginButton
            // 
            toLoginButton.Anchor = AnchorStyles.Bottom;
            toLoginButton.Location = new Point(474, 334);
            toLoginButton.Name = "toLoginButton";
            toLoginButton.Size = new Size(208, 42);
            toLoginButton.TabIndex = 10;
            toLoginButton.Text = "Go to login";
            toLoginButton.UseVisualStyleBackColor = true;
            toLoginButton.Click += toLoginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Anchor = AnchorStyles.Bottom;
            signupButton.Location = new Point(474, 286);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(208, 42);
            signupButton.TabIndex = 9;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // signupControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toLoginButton);
            Controls.Add(signupButton);
            Name = "signupControl";
            Size = new Size(1157, 609);
            Load += signupControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox displayNameBox;
        private Button toLoginButton;
        private Button signupButton;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox confirmPassBox;
    }
}
