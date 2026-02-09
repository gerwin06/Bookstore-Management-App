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
    public partial class customerControl : UserControl
    {
        public event Action? clickedCart;
        public event Action? logoutClicked;
        private CustomerAccount? currentAccount;
        public CustomerAccount CurrentAccount
        {
            set
            {
                currentAccount = value;
                if (currentAccount != null)
                {
                    labelWelcome.Text = $"Welcome, {currentAccount.DisplayName}";
                }
            }
        }
        public customerControl()
        {
            InitializeComponent();

            this.VisibleChanged += new EventHandler(customerControl_VisibleChanged);

            cBoxFilter.Items.AddRange(new string[] { "Title", "Author" });
            cBoxFilter.SelectedIndex = 0;

            dgvInventory.Columns.Add("Title", "Title");
            dgvInventory.Columns.Add("Author", "Author");
            dgvInventory.Columns.Add("Stock", "Stock");
            dgvInventory.Columns.Add("Price", "Price");

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.HeaderText = "Action";
            addButton.Name = "Action";
            addButton.Text = "Add to Cart";
            addButton.UseColumnTextForButtonValue = true;

            dgvInventory.Columns.Add(addButton);

            dgvInventory.Columns["Title"].Width = 150;
            dgvInventory.Columns["Author"].Width = 150;
            dgvInventory.Columns["Stock"].Width = 70;
            dgvInventory.Columns["Price"].Width = 60;
            dgvInventory.Columns["Action"].Width = 80;

            dgvInventory.Columns["Title"].DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvInventory.Columns["Price"].DefaultCellStyle.Format = "C2";
            dgvInventory.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

            LoadInventory();
        }

        private void customerControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadInventory();
                textBoxSearch.Clear();
            }
        }


        public void setCurrentAccount(Account currentAcc)
        {

        }

        public void LoadInventory(string? keySearch = null, bool isTitle = true)
        {
            string selectedBookTitle = null;
            if (dgvInventory.SelectedRows.Count > 0)
            {
                selectedBookTitle = dgvInventory.SelectedRows[0].Cells["Title"].Value.ToString();
            }

            dgvInventory.Rows.Clear();

            string booksPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "books.txt"
            );

            if (!File.Exists(booksPath))
            {
                MessageBox.Show("books.txt file not found!");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(booksPath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split('~');

                    if (parts.Length != 6)
                    {
                        continue;
                    }

                    string bookTitle = parts[0].Trim();
                    string bookAuthor = parts[1].Trim();
                    string publisher = parts[2].Trim();
                    string genre = parts[3].Trim();

                    if (!decimal.TryParse(parts[4].Trim(), out decimal price))
                    {
                        continue;
                    }

                    if (!int.TryParse(parts[5].Trim(), out int stock))
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(keySearch))
                    {
                        if (isTitle && !bookTitle.Contains(keySearch, StringComparison.OrdinalIgnoreCase))
                            continue;

                        if (!isTitle && !bookAuthor.Contains(keySearch, StringComparison.OrdinalIgnoreCase))
                            continue;
                    }

                    int rowIndex = dgvInventory.Rows.Add(bookTitle, bookAuthor, stock, price);
                    var row = dgvInventory.Rows[rowIndex];
                    row.Height = 30;

                    if (stock == 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.Font = new Font(dgvInventory.Font, FontStyle.Italic);
                    }
                }

                if (dgvInventory.Rows.Count == 0 && !string.IsNullOrEmpty(keySearch))
                {
                    MessageBox.Show("No books found matching your search.");
                }

                if (selectedBookTitle != null)
                {
                    foreach (DataGridViewRow row in dgvInventory.Rows)
                    {
                        if (row.Cells["Title"].Value.ToString() == selectedBookTitle)
                        {
                            row.Selected = true;
                            dgvInventory.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"File read error: {e.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Unexpected error: {e.Message}");
            }
        }
        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                string booksPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "books.txt");

                DataGridViewRow selectedRow = dgvInventory.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value?.ToString() ?? "";

                try
                {
                    string[] lines = File.ReadAllLines(booksPath);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split('~');

                        if (parts.Length != 6)
                        {
                            continue;
                        }

                        string bookTitle = parts[0].Trim();
                        string bookAuthor = parts[1].Trim();
                        string publisher = parts[2].Trim();
                        string genre = parts[3].Trim();
                        decimal price = decimal.Parse(parts[4].Trim());
                        int stock = int.Parse(parts[5].Trim());

                        if (bookTitle.Equals(title))
                        {
                            labelBookTitle.Text = bookTitle;
                            labelBookAuthor.Text = bookAuthor;
                            labelBookInfo.Text = $"Genre: {genre}\nPublisher: {publisher}";

                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching book details: {ex.Message}", "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logoutClicked?.Invoke();
        }

        private void customerControl_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quantityHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadInventory(textBoxSearch.Text.Trim(), (cBoxFilter.Text == "Title"));
        }

        private void AddItemToCart(DataGridViewRow selectedRow, int quantityToAdd)
        {
            int stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);

            if (stock <= 0)
            {
                MessageBox.Show("This item is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantityToAdd <= 0)
            {
                MessageBox.Show("Please select a quantity greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantityToAdd > stock)
            {
                MessageBox.Show($"Cannot add {quantityToAdd} item(s). Only {stock} available in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = selectedRow.Cells["Title"].Value.ToString();

            if (InventoryManager.UpdateStock(title, -quantityToAdd))
            {
                try
                {
                    currentAccount.Cart.AddItem(new CartItem
                    {
                        Title = title,
                        Author = selectedRow.Cells["Author"].Value.ToString(),
                        Price = decimal.Parse(selectedRow.Cells["Price"].Value.ToString()),
                        Quantity = quantityToAdd,
                    });

                    MessageBox.Show($"'{title}' ({quantityToAdd}) has been added to your cart!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory(textBoxSearch.Text.Trim(), (cBoxFilter.Text == "Title"));
                }
                catch (Exception ex)
                {
                    InventoryManager.UpdateStock(title, quantityToAdd);
                    MessageBox.Show($"An error occurred while adding to the cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to update inventory. Item not added to cart.", "Inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvInventory.Columns[e.ColumnIndex].Name == "Action")
            {
                DataGridViewRow selectedRow = dgvInventory.Rows[e.RowIndex];
                AddItemToCart(selectedRow, 1);
            }
        }

        private void buttonBookAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInventory.SelectedRows[0];
                int quantityToAdd = (int)nudQuantity.Value;
                AddItemToCart(selectedRow, quantityToAdd);
            }
            else
            {
                MessageBox.Show("Please select a book from the list first.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            clickedCart?.Invoke();
        }

        private void labelBookAuthor_Click(object sender, EventArgs e)
        {

        }
    }
}