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
    public partial class viewCart : UserControl
    {
        public event Action? toCustomerPageClicked;
        private CustomerAccount? currentAccount;
        public CustomerAccount CurrentAccount
        {
            set
            {
                if (currentAccount != null && currentAccount.Cart != null)
                {
                    currentAccount.Cart.CartUpdated -= OnCartUpdated;
                }

                currentAccount = value;
                if (currentAccount != null && currentAccount.Cart != null)
                {
                    currentAccount.Cart.CartUpdated += OnCartUpdated;
                    LoadCart();
                }
            }
        }

        public viewCart()
        {
            InitializeComponent();
        }

        private void OnCartUpdated()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(LoadCart));
            }
            else
            {
                LoadCart();
            }
        }

        public void LoadCart()
        {
            string searchTerm = textBoxSearch.Text.Trim();
            dgvInventory.Rows.Clear();

            if (currentAccount == null)
            {
                UpdateSummary();
                return;
            }

            Cart accountCart = currentAccount.Cart;
            foreach (CartItem cItem in accountCart.Items)
            {
                if (!string.IsNullOrEmpty(searchTerm) &&
                    !cItem.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                int rowIndex = dgvInventory.Rows.Add(cItem.Title, cItem.Quantity, cItem.Price, cItem.Subtotal);
                var row = dgvInventory.Rows[rowIndex];
                row.Height = 30;
            }

            dgvInventory.Columns["dataGridViewTextBoxColumn3"].DefaultCellStyle.Format = "c";
            dgvInventory.Columns["dataGridViewTextBoxColumn4"].DefaultCellStyle.Format = "c";

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            if (currentAccount != null && currentAccount.Cart != null)
            {
                decimal subtotal = currentAccount.Cart.GetSubtotal();
                decimal tax = currentAccount.Cart.GetTax();
                decimal total = currentAccount.Cart.GetTotal();

                labelSummary.Text = $"Subtotal: {subtotal:C}\n" +
                                    $"Tax (8%): {tax:C}\n\n" +
                                    $"Total: {total:C}";
            }
            else
            {
                labelSummary.Text = "Subtotal: ₱0.00\n" +
                                    "Tax (8%): ₱0.00\n\n" +
                                    "Total: ₱0.00";
            }
        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            if (currentAccount != null && currentAccount.Cart.Items.Any())
            {
                var result = MessageBox.Show("Are you sure you want to clear your cart?", "Confirm Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    currentAccount.Cart.Clear();
                }
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvInventory.SelectedRows[0];
                string title = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                int quantity = (int)selectedRow.Cells["dataGridViewTextBoxColumn2"].Value;

                if (currentAccount != null && !string.IsNullOrEmpty(title))
                {
                    currentAccount.Cart.RemoveItem(title);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (currentAccount == null || !currentAccount.Cart.Items.Any())
            {
                MessageBox.Show("Your cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmationText = new StringBuilder();
            confirmationText.AppendLine("Please confirm your order:\n");

            foreach (var item in currentAccount.Cart.Items)
            {
                confirmationText.AppendLine($"- {item.Title,-40} x{item.Quantity,-5} -> {item.Subtotal,8:C}");
            }

            confirmationText.AppendLine($"\n{new string('-', 33)}");
            confirmationText.AppendLine($"Total: {currentAccount.Cart.GetTotal():C}");

            var result = MessageBox.Show(confirmationText.ToString(), "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProcessCheckout();
            }
        }

        private void ProcessCheckout()
        {
            try
            {
                string receiptContent = GenerateReceiptText();

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string username = currentAccount.Username;
                string fileName = $"receipt_{username}_{timestamp}.txt";

                string basePath = Path.Combine(
                    Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                    "receipts"
                );

                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                string filePath = Path.Combine(basePath, fileName);

                File.WriteAllText(filePath, receiptContent);

                currentAccount.Cart.ClearAfterCheckout();

                MessageBox.Show($"Checkout successful!\n\nReceipt saved to:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateReceiptText()
        {
            var receipt = new StringBuilder();
            receipt.AppendLine("--- COMIC BOOKSTORE RECEIPT ---");
            receipt.AppendLine($"Date: {DateTime.Now}");
            receipt.AppendLine($"Customer: {currentAccount.DisplayName} ({currentAccount.Username})");
            receipt.AppendLine("---------------------------------");
            receipt.AppendLine();

            foreach (var item in currentAccount.Cart.Items)
            {
                receipt.AppendLine($"{item.Title,-40} x{item.Quantity,-5} {item.Price,8:C} = {item.Subtotal,8:C}");
            }

            receipt.AppendLine();
            receipt.AppendLine("---------------------------------");
            receipt.AppendLine($"Subtotal: {currentAccount.Cart.GetSubtotal(),20:C}");
            receipt.AppendLine($"Tax (8%): {currentAccount.Cart.GetTax(),21:C}");
            receipt.AppendLine($"TOTAL:    {currentAccount.Cart.GetTotal(),21:C}");
            receipt.AppendLine();
            receipt.AppendLine("--- THANK YOU FOR YOUR PURCHASE ---");

            return receipt.ToString();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void buttonBack_Clicked(object sender, EventArgs e) => toCustomerPageClicked?.Invoke();

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCart();
                e.SuppressKeyPress = true;
            }
        }
    }
}