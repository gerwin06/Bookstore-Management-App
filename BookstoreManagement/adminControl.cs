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
    public partial class adminControl : UserControl
    {
        private readonly string booksPath = Path.Combine(
            Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
            "books.txt"
        );

        private bool isEditMode = false;
        private string? originalBookTitleToEdit;
        public event Action? logoutClicked;

        public adminControl()
        {
            InitializeComponent();
            LoadInventory();
            cmbSearchBy.SelectedIndex = 0;

            dgvInventory.Columns.Clear();
            dgvInventory.Columns.Add("Title", "Title");
            dgvInventory.Columns.Add("Author", "Author");
            dgvInventory.Columns.Add("Publisher", "Publisher");
            dgvInventory.Columns.Add("Genre", "Genre");
            dgvInventory.Columns.Add("Price", "Price");
            dgvInventory.Columns.Add("Stock", "Stock");
            dgvInventory.Columns["Price"].DefaultCellStyle.Format = "C2";

            this.VisibleChanged += (s, e) => { if (this.Visible) LoadInventory(); };
        }

        private void LoadInventory(string? searchTerm = null, string searchBy = "Title")
        {
            dgvInventory.Rows.Clear();
            if (!File.Exists(booksPath))
            {
                MessageBox.Show("books.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var lines = File.ReadAllLines(booksPath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split('~');
                    if (parts.Length != 6) continue;

                    var book = new Book
                    {
                        Title = parts[0],
                        Author = parts[1],
                        Publisher = parts[2],
                        Genre = parts[3],
                        Price = decimal.Parse(parts[4]),
                        Stock = int.Parse(parts[5])
                    };

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        if (searchBy == "Title" && !book.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                            continue;

                        if (searchBy == "Author" && !book.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                            continue;
                    }

                    dgvInventory.Rows.Add(book.Title, book.Author, book.Publisher, book.Genre, book.Price, book.Stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            LoadInventory(txtSearch.Text.Trim(), cmbSearchBy.SelectedItem.ToString());
        }

        private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnAddNew_Click(object? sender, EventArgs e)
        {
            isEditMode = false;
            originalBookTitleToEdit = null;
            ResetEditPanel(true);
            lblEditTitle.Text = "Add New Book";
            textBoxTitle.ReadOnly = false;
            pnlEdit.Visible = true;
        }

        private void BtnEditSelected_Click(object? sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isEditMode = true;
            ResetEditPanel(true);
            lblEditTitle.Text = "Edit Book";

            var selectedRow = dgvInventory.SelectedRows[0];
            originalBookTitleToEdit = selectedRow.Cells["Title"].Value.ToString();

            textBoxTitle.Text = originalBookTitleToEdit;
            textBoxAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
            textBoxPublisher.Text = selectedRow.Cells["Publisher"].Value.ToString();
            cmbGenre.SelectedItem = selectedRow.Cells["Genre"].Value.ToString();
            nudPrice.Value = (decimal)selectedRow.Cells["Price"].Value;
            nudStock.Value = Convert.ToDecimal(selectedRow.Cells["Stock"].Value);

            textBoxTitle.ReadOnly = true;
            pnlEdit.Visible = true;
        }

        private void BtnDeleteSelected_Click(object? sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedRow = dgvInventory.SelectedRows[0];
            string titleToDelete = selectedRow.Cells["Title"].Value.ToString();
            var result = MessageBox.Show($"Are you sure you want to delete '{titleToDelete}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var lines = File.ReadAllLines(booksPath).ToList();
                    lines.RemoveAll(line => line.Split('~')[0].Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));
                    File.WriteAllLines(booksPath, lines);
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(textBoxAuthor.Text) ||
                string.IsNullOrWhiteSpace(textBoxPublisher.Text) || cmbGenre.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var book = new Book
            {
                Title = textBoxTitle.Text.Trim(),
                Author = textBoxAuthor.Text.Trim(),
                Publisher = textBoxPublisher.Text.Trim(),
                Genre = cmbGenre.SelectedItem.ToString(),
                Price = nudPrice.Value,
                Stock = (int)nudStock.Value
            };

            try
            {
                var lines = File.ReadAllLines(booksPath).ToList();

                if (isEditMode)
                {
                    int index = lines.FindIndex(line => line.Split('~')[0].Equals(originalBookTitleToEdit, StringComparison.OrdinalIgnoreCase));
                    if (index != -1)
                    {
                        lines[index] = book.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The original book to edit could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (lines.Any(line => line.Split('~')[0].Equals(book.Title, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("A book with this title already exists.", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lines.Add(book.ToString());
                }

                File.WriteAllLines(booksPath, lines);
                MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadInventory(txtSearch.Text.Trim(), cmbSearchBy.SelectedItem.ToString());
                ResetEditPanel(false);
                isEditMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelEdit_Click(object? sender, EventArgs e)
        {
            ResetEditPanel(false);
            isEditMode = false;
        }

        private void ResetEditPanel(bool show)
        {
            pnlEdit.Visible = show;

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxPublisher.Clear();
            cmbGenre.SelectedIndex = -1;
            nudPrice.Value = 0;
            nudStock.Value = 0;
            originalBookTitleToEdit = null;
            textBoxTitle.ReadOnly = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logoutClicked?.Invoke();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}