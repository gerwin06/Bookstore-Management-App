using System.Reflection;

namespace BookstoreManagement
{
    public class CartItem
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal => Price * Quantity;
        public override string ToString() => $"{Title}~{Author}~{Price}~{Quantity}";

        public static CartItem FromString(string line)
        {
            var parts = line.Split('~');
            if (parts.Length != 4)
                throw new FormatException($"Invalid cart line: {line}");

            return new CartItem
            {
                Title = parts[0],
                Author = parts[1],
                Price = decimal.Parse(parts[2]),
                Quantity = int.Parse(parts[3])
            };
        }
    }

    public class Cart
    {
        public event Action? CartUpdated;
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        private string cartFilePath;

        public decimal GetSubtotal()
        {
            decimal total = 0;
            foreach (CartItem cartItem in Items)
            {
                total += cartItem.Subtotal;
            }
            return total;
        }
        public decimal GetTax()
        {
            return GetSubtotal() * 0.08m;
        }
        public decimal GetTotal()
        {
            return GetSubtotal() + GetTax();
        }

        public Cart(string username)
        {
            string basePath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "carts"
            );

            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            cartFilePath = Path.Combine(basePath, $"cart_{username}.txt");
            LoadCart();
        }

        public void AddItem(CartItem item)
        {

            CartItem? foundItem = null;
            foreach (CartItem cartItem in Items)
            {
                if (cartItem.Title.Equals(item.Title, StringComparison.OrdinalIgnoreCase) &&
                    cartItem.Author.Equals(item.Author, StringComparison.OrdinalIgnoreCase)
                    )
                {
                    foundItem = cartItem;
                    break;
                }
            }

            if (foundItem != null)
                foundItem.Quantity += item.Quantity;
            else
                Items.Add(item);

            SaveCart();
            CartUpdated?.Invoke();
        }

        public void RemoveItem(string title)
        {
            var itemToRemove = Items.FirstOrDefault(i => i.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                InventoryManager.UpdateStock(itemToRemove.Title, itemToRemove.Quantity);

                Items.Remove(itemToRemove);

                SaveCart();
                CartUpdated?.Invoke();
            }
        }

        public void Clear()
        {
            if (Items.Any())
            {
                foreach (var item in Items)
                {
                    InventoryManager.UpdateStock(item.Title, item.Quantity);
                }

                Items.Clear();
                SaveCart();
                CartUpdated?.Invoke();
            }
        }

        public void ClearAfterCheckout()
        {
            if (Items.Any())
            {
                Items.Clear();
                SaveCart();
                CartUpdated?.Invoke();
            }
        }

        public void SaveCart()
        {
            try
            {
                var lines = Items.Select(i => i.ToString());
                File.WriteAllLines(cartFilePath, lines);
            }
            catch (IOException e)
            {
                MessageBox.Show($"Error saving cart: {e.Message}");
            }
        }

        public void LoadCart()
        {
            Items.Clear();
            if (!File.Exists(cartFilePath))
                return;

            try
            {
                foreach (var line in File.ReadAllLines(cartFilePath))
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    Items.Add(CartItem.FromString(line));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error loading cart: {e.Message}");
            }
        }
    }
}