using System;
namespace InventoryManagementSystem
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public int Quantity;
        public double Price;
        public Product(
            int productId,
            string productName,
            int quantity,
            double price)
        {
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine(ProductId +" | " +ProductName +" | Qty: " +Quantity +" | Price: " +Price);
        }
    }
}