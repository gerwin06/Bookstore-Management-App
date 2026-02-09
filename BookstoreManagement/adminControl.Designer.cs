// AdminControl.Designer.cs
namespace BookstoreManagement
{
    partial class adminControl
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
            pnlSearch = new Panel();
            buttonLogout = new Button();
            btnSearch = new Button();
            cmbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            dgvInventory = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            pnlActions = new Panel();
            btnAddNew = new Button();
            btnEditSelected = new Button();
            btnDeleteSelected = new Button();
            pnlEdit = new Panel();
            buttonConfirm = new Button();
            lblEditTitle = new Label();
            lblTitle = new Label();
            textBoxTitle = new TextBox();
            lblAuthor = new Label();
            textBoxAuthor = new TextBox();
            lblPublisher = new Label();
            textBoxPublisher = new TextBox();
            lblGenre = new Label();
            cmbGenre = new ComboBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            btnSaveBook = new Button();
            btnCancelEdit = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            pnlActions.SuspendLayout();
            pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.Transparent;
            pnlSearch.Controls.Add(buttonLogout);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(cmbSearchBy);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(8);
            pnlSearch.Size = new Size(1157, 48);
            pnlSearch.TabIndex = 6;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLogout.Location = new Point(1050, 10);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(96, 28);
            buttonLogout.TabIndex = 16;
            buttonLogout.Text = "Log out";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(856, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "Title", "Author" });
            cmbSearchBy.Location = new Point(730, 14);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(120, 23);
            cmbSearchBy.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(11, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter search term...";
            txtSearch.Size = new Size(713, 23);
            txtSearch.TabIndex = 0;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(0, 92);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1157, 317);
            dgvInventory.TabIndex = 3;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            dgvInventory.Columns.Add("Title", "Title");
            dgvInventory.Columns.Add("Author", "Author");
            dgvInventory.Columns.Add("Publisher", "Publisher");
            dgvInventory.Columns.Add("Genre", "Genre");
            dgvInventory.Columns.Add("Price", "Price");
            dgvInventory.Columns.Add("Stock", "Stock");
            dgvInventory.Columns["Price"].DefaultCellStyle.Format = "C2";
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.Transparent;
            pnlActions.Controls.Add(btnAddNew);
            pnlActions.Controls.Add(btnEditSelected);
            pnlActions.Controls.Add(btnDeleteSelected);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 48);
            pnlActions.Name = "pnlActions";
            pnlActions.Padding = new Padding(8);
            pnlActions.Size = new Size(1157, 44);
            pnlActions.TabIndex = 4;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Left;
            btnAddNew.Location = new Point(12, 8);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(110, 28);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "Add New Book";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += BtnAddNew_Click;
            // 
            // btnEditSelected
            // 
            btnEditSelected.Anchor = AnchorStyles.Left;
            btnEditSelected.Location = new Point(132, 8);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(110, 28);
            btnEditSelected.TabIndex = 5;
            btnEditSelected.Text = "Edit Selected";
            btnEditSelected.UseVisualStyleBackColor = true;
            btnEditSelected.Click += BtnEditSelected_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.Anchor = AnchorStyles.Left;
            btnDeleteSelected.Location = new Point(252, 8);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(120, 28);
            btnDeleteSelected.TabIndex = 6;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = true;
            btnDeleteSelected.Click += BtnDeleteSelected_Click;
            // 
            // pnlEdit
            // 
            pnlEdit.BackColor = Color.FromArgb(245, 245, 245);
            pnlEdit.Controls.Add(buttonConfirm);
            pnlEdit.Controls.Add(lblEditTitle);
            pnlEdit.Controls.Add(lblTitle);
            pnlEdit.Controls.Add(textBoxTitle);
            pnlEdit.Controls.Add(lblAuthor);
            pnlEdit.Controls.Add(textBoxAuthor);
            pnlEdit.Controls.Add(lblPublisher);
            pnlEdit.Controls.Add(textBoxPublisher);
            pnlEdit.Controls.Add(lblGenre);
            pnlEdit.Controls.Add(cmbGenre);
            pnlEdit.Controls.Add(lblPrice);
            pnlEdit.Controls.Add(nudPrice);
            pnlEdit.Controls.Add(lblStock);
            pnlEdit.Controls.Add(nudStock);
            pnlEdit.Controls.Add(btnSaveBook);
            pnlEdit.Controls.Add(btnCancelEdit);
            pnlEdit.Dock = DockStyle.Bottom;
            pnlEdit.Location = new Point(0, 409);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Padding = new Padding(12);
            pnlEdit.Size = new Size(1157, 200);
            pnlEdit.TabIndex = 5;
            pnlEdit.Visible = false;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirm.Location = new Point(916, 159);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(110, 28);
            buttonConfirm.TabIndex = 15;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += BtnConfirm_Click;
            // 
            // lblEditTitle
            // 
            lblEditTitle.AutoSize = true;
            lblEditTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditTitle.Location = new Point(12, 10);
            lblEditTitle.Name = "lblEditTitle";
            lblEditTitle.Size = new Size(129, 21);
            lblEditTitle.TabIndex = 0;
            lblEditTitle.Text = "Add / Edit Book";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(14, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(90, 40);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(420, 23);
            textBoxTitle.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(14, 74);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(90, 70);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(300, 23);
            textBoxAuthor.TabIndex = 8;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(14, 104);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(59, 15);
            lblPublisher.TabIndex = 9;
            lblPublisher.Text = "Publisher:";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(90, 100);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(300, 23);
            textBoxPublisher.TabIndex = 9;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(14, 134);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(41, 15);
            lblGenre.TabIndex = 10;
            lblGenre.Text = "Genre:";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Manga", "Superhero", "Graphic Novel", "Fantasy", "Sci-Fi", "Horror", "Other" });
            cmbGenre.Location = new Point(90, 130);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(200, 23);
            cmbGenre.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(320, 134);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price:";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(370, 130);
            nudPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(140, 23);
            nudPrice.TabIndex = 11;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(14, 166);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock:";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(90, 162);
            nudStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(120, 23);
            nudStock.TabIndex = 12;
            // 
            // btnSaveBook
            // 
            btnSaveBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveBook.Location = new Point(1467, 156);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(100, 28);
            btnSaveBook.TabIndex = 13;
            btnSaveBook.Text = "Save Book";
            btnSaveBook.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelEdit.Location = new Point(1357, 156);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(100, 28);
            btnCancelEdit.TabIndex = 14;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Click += BtnCancelEdit_Click;
            // 
            // adminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvInventory);
            Controls.Add(pnlActions);
            Controls.Add(pnlEdit);
            Controls.Add(pnlSearch);
            Name = "adminControl";
            Size = new Size(1157, 609);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            pnlActions.ResumeLayout(false);
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearch;
        private TextBox txtSearch;
        private ComboBox cmbSearchBy;
        private Button btnSearch;
        private DataGridView dgvInventory;
        private Panel pnlActions;
        private Button btnAddNew;
        private Button btnEditSelected;
        private Button btnDeleteSelected;
        private Panel pnlEdit;
        private Label lblEditTitle;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblGenre;
        private Label lblPrice;
        private Label lblStock;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxPublisher;
        private ComboBox cmbGenre;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private Button btnSaveBook;
        private Button btnCancelEdit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button buttonConfirm;
        private Button buttonLogout;
    }
}