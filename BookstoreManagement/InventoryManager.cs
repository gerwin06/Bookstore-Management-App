namespace BookstoreManagement
{
    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{Title}~{Author}~{Publisher}~{Genre}~{Price}~{Stock}";
        }
    }

    public static class InventoryManager
    {
        private static readonly string booksPath = Path.Combine(
            Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
            "books.txt"
        );

        public static bool UpdateStock(string title, int quantityChange)
        { 
                try
                {
                    var lines = File.ReadAllLines(booksPath).ToList();
                    for (int i = 0; i < lines.Count; i++)
                    {
                        var parts = lines[i].Split('~');
                        if (parts.Length == 6 && parts[0].Trim().Equals(title, StringComparison.OrdinalIgnoreCase))
                        {
                            if (!int.TryParse(parts[5].Trim(), out int currentStock))
                            {
                                return false;
                            }

                            int newStock = currentStock + quantityChange;

                            if (newStock < 0)
                            {
                                return false; 
                            }

                            parts[5] = newStock.ToString();
                            lines[i] = string.Join("~", parts);

                            File.WriteAllLines(booksPath, lines);
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating inventory: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
           

            return false;
        }
    }
}