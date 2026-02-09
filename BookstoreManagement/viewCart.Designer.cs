namespace BookstoreManagement
{
    partial class viewCart
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
            tableLayoutPanel2 = new TableLayoutPanel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dgvInventory = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRemoveSelected = new Button();
            buttonClearCart = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonBack = new Button();
            buttonCheckout = new Button();
            panel2 = new Panel();
            labelSummary = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.TabIndex = 1;
            label1.Text = "My Cart";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel2.Controls.Add(labelSearch, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxSearch, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonSearch, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 36);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1157, 40);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Left;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(441, 9);
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
            textBoxSearch.Location = new Point(501, 8);
            textBoxSearch.Margin = new Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(167, 23);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(673, 5);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(38, 30);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "🔍";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
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
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(90, 20);
            dgvInventory.Margin = new Padding(0);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(973, 281);
            dgvInventory.TabIndex = 5;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Title";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Qty";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Price";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Subtotal";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dgvInventory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 76);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(90, 20, 90, 20);
            panel1.Size = new Size(1157, 325);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonRemoveSelected, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonClearCart, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 401);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1157, 40);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonRemoveSelected
            // 
            buttonRemoveSelected.Anchor = AnchorStyles.Top;
            buttonRemoveSelected.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveSelected.Location = new Point(381, 5);
            buttonRemoveSelected.Margin = new Padding(5);
            buttonRemoveSelected.Name = "buttonRemoveSelected";
            buttonRemoveSelected.Size = new Size(176, 30);
            buttonRemoveSelected.TabIndex = 8;
            buttonRemoveSelected.Text = "Remove Selected";
            buttonRemoveSelected.UseVisualStyleBackColor = true;
            buttonRemoveSelected.Click += buttonRemoveSelected_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Anchor = AnchorStyles.Top;
            buttonClearCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClearCart.Location = new Point(600, 5);
            buttonClearCart.Margin = new Padding(5);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(176, 30);
            buttonClearCart.TabIndex = 9;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 726F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonBack, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonCheckout, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 569);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1157, 40);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Top;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(34, 5);
            buttonBack.Margin = new Padding(5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(176, 30);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Clicked;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Anchor = AnchorStyles.Top;
            buttonCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckout.Location = new Point(946, 5);
            buttonCheckout.Margin = new Padding(5);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(176, 30);
            buttonCheckout.TabIndex = 9;
            buttonCheckout.Text = " Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelSummary);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 441);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 128);
            panel2.TabIndex = 9;
            // 
            // labelSummary
            // 
            labelSummary.Dock = DockStyle.Fill;
            labelSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSummary.Location = new Point(0, 0);
            labelSummary.Name = "labelSummary";
            labelSummary.Padding = new Padding(300, 10, 0, 0);
            labelSummary.Size = new Size(1157, 128);
            labelSummary.TabIndex = 0;
            labelSummary.Text = "SubTotal: ";
            // 
            // viewCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Name = "viewCart";
            Size = new Size(1157, 609);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private DataGridView dgvInventory;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRemoveSelected;
        private Button buttonClearCart;
        private Button buttonSearch;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonBack;
        private Button buttonCheckout;
        private Panel panel2;
        private Label labelSummary;
    }
}