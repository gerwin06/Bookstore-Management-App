namespace BookstoreManagement
{
    partial class customerControl
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonLogout = new Button();
            buttonCart = new Button();
            labelWelcome = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSearch = new Button();
            label2 = new Label();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            cBoxFilter = new ComboBox();
            lineSeparator = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvInventory = new DataGridView();
            panel1 = new Panel();
            labelBookInfo = new Label();
            quantityHolder = new TableLayoutPanel();
            label3 = new Label();
            nudQuantity = new NumericUpDown();
            buttonBookAddToCart = new Button();
            labelBookAuthor = new Label();
            labelBookTitle = new Label();
            lblHeaderBookDetails = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            quantityHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0, 3, 0, 3);
            label1.Name = "label1";
            label1.Size = new Size(1157, 36);
            label1.TabIndex = 0;
            label1.Text = "Comic Bookstore";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonLogout, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonCart, 2, 0);
            tableLayoutPanel1.Controls.Add(labelWelcome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1157, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Fill;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(1017, 10);
            buttonLogout.Margin = new Padding(10, 10, 20, 10);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(120, 40);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "Log Out";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonCart
            // 
            buttonCart.Dock = DockStyle.Fill;
            buttonCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCart.Location = new Point(877, 10);
            buttonCart.Margin = new Padding(10);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(120, 40);
            buttonCart.TabIndex = 3;
            buttonCart.Text = "Cart";
            buttonCart.UseVisualStyleBackColor = true;
            buttonCart.Click += buttonCart_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.Dock = DockStyle.Fill;
            labelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(10, 0);
            labelWelcome.Margin = new Padding(10, 0, 3, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(500, 60);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome, DisplayName!";
            labelWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonSearch, 5, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(labelSearch, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxSearch, 2, 0);
            tableLayoutPanel2.Controls.Add(cBoxFilter, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 98);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1157, 40);
            tableLayoutPanel2.TabIndex = 3;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(722, 5);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(111, 30);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(556, 9);
            label2.Margin = new Padding(10, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 5;
            label2.Text = "By:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Left;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(319, 9);
            labelSearch.Margin = new Padding(0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 21);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Search:";
            labelSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Location = new Point(379, 8);
            textBoxSearch.Margin = new Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(167, 23);
            textBoxSearch.TabIndex = 4;
            // 
            // cBoxFilter
            // 
            cBoxFilter.Anchor = AnchorStyles.Left;
            cBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxFilter.FormattingEnabled = true;
            cBoxFilter.Location = new Point(591, 5);
            cBoxFilter.Margin = new Padding(5);
            cBoxFilter.Name = "cBoxFilter";
            cBoxFilter.Size = new Size(121, 29);
            cBoxFilter.TabIndex = 6;
            cBoxFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lineSeparator
            // 
            lineSeparator.BackColor = Color.Gray;
            lineSeparator.Dock = DockStyle.Top;
            lineSeparator.Location = new Point(0, 96);
            lineSeparator.Margin = new Padding(0);
            lineSeparator.Name = "lineSeparator";
            lineSeparator.Size = new Size(1157, 2);
            lineSeparator.TabIndex = 4;
            lineSeparator.Text = "label2";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.03371F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9662914F));
            tableLayoutPanel3.Controls.Add(dgvInventory, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 138);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1157, 471);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToOrderColumns = true;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = SystemColors.ControlLight;
            dgvInventory.BorderStyle = BorderStyle.Fixed3D;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(3, 3);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(839, 465);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            dgvInventory.SelectionChanged += dgvInventory_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelBookInfo);
            panel1.Controls.Add(quantityHolder);
            panel1.Controls.Add(buttonBookAddToCart);
            panel1.Controls.Add(labelBookAuthor);
            panel1.Controls.Add(labelBookTitle);
            panel1.Controls.Add(lblHeaderBookDetails);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(848, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 5, 5, 10);
            panel1.Size = new Size(306, 465);
            panel1.TabIndex = 1;
            // 
            // labelBookInfo
            // 
            labelBookInfo.Dock = DockStyle.Bottom;
            labelBookInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookInfo.Location = new Point(5, 160);
            labelBookInfo.Name = "labelBookInfo";
            labelBookInfo.Padding = new Padding(30, 0, 0, 0);
            labelBookInfo.Size = new Size(292, 212);
            labelBookInfo.TabIndex = 5;
            labelBookInfo.Text = "Genre: Genres";
            // 
            // quantityHolder
            // 
            quantityHolder.ColumnCount = 2;
            quantityHolder.ColumnStyles.Add(new ColumnStyle());
            quantityHolder.ColumnStyles.Add(new ColumnStyle());
            quantityHolder.Controls.Add(label3);
            quantityHolder.Controls.Add(nudQuantity, 1, 0);
            quantityHolder.Dock = DockStyle.Bottom;
            quantityHolder.Location = new Point(5, 372);
            quantityHolder.Name = "quantityHolder";
            quantityHolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            quantityHolder.Size = new Size(292, 39);
            quantityHolder.TabIndex = 7;
            quantityHolder.Paint += quantityHolder_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(144, 39);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Anchor = AnchorStyles.Left;
            nudQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(147, 5);
            nudQuantity.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(82, 29);
            nudQuantity.TabIndex = 6;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // buttonBookAddToCart
            // 
            buttonBookAddToCart.Dock = DockStyle.Bottom;
            buttonBookAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBookAddToCart.Location = new Point(5, 411);
            buttonBookAddToCart.Margin = new Padding(10);
            buttonBookAddToCart.Name = "buttonBookAddToCart";
            buttonBookAddToCart.Size = new Size(292, 40);
            buttonBookAddToCart.TabIndex = 6;
            buttonBookAddToCart.Text = "Add To Cart";
            buttonBookAddToCart.UseVisualStyleBackColor = true;
            buttonBookAddToCart.Click += buttonBookAddToCart_Click;
            // 
            // labelBookAuthor
            // 
            labelBookAuthor.Dock = DockStyle.Top;
            labelBookAuthor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookAuthor.Location = new Point(5, 77);
            labelBookAuthor.Name = "labelBookAuthor";
            labelBookAuthor.Size = new Size(292, 24);
            labelBookAuthor.TabIndex = 4;
            labelBookAuthor.Text = "By Author";
            labelBookAuthor.TextAlign = ContentAlignment.TopCenter;
            labelBookAuthor.Click += labelBookAuthor_Click;
            // 
            // labelBookTitle
            // 
            labelBookTitle.Dock = DockStyle.Top;
            labelBookTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookTitle.Location = new Point(5, 41);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Padding = new Padding(0, 15, 0, 0);
            labelBookTitle.Size = new Size(292, 36);
            labelBookTitle.TabIndex = 3;
            labelBookTitle.Text = "Title";
            labelBookTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderBookDetails
            // 
            lblHeaderBookDetails.Dock = DockStyle.Top;
            lblHeaderBookDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderBookDetails.Location = new Point(5, 5);
            lblHeaderBookDetails.Name = "lblHeaderBookDetails";
            lblHeaderBookDetails.Size = new Size(292, 36);
            lblHeaderBookDetails.TabIndex = 2;
            lblHeaderBookDetails.Text = "Book Details";
            lblHeaderBookDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lineSeparator);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "customerControl";
            Size = new Size(1157, 609);
            Load += customerControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            quantityHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelWelcome;
        private Button buttonLogout;
        private Button buttonCart;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Label lineSeparator;
        private Label label2;
        private ComboBox cBoxFilter;
        private Button buttonSearch;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvInventory;
        private Panel panel1;
        private Label lblHeaderBookDetails;
        private Label labelBookTitle;
        private Label labelBookAuthor;
        private Label labelBookInfo;
        private Button buttonBookAddToCart;
        private Label label3;
        private TableLayoutPanel quantityHolder;
        private NumericUpDown nudQuantity;
    }
}
