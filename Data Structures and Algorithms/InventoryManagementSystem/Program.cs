using System;
namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory =new Inventory();
            Product p1 =new Product(101,"Laptop",20,55000);
            Product p2 =new Product(102,"Mouse",100,500);
            inventory.AddProduct(p1);
            inventory.AddProduct(p2);

            Console.WriteLine("\nCurrent Inventory");
            inventory.ShowProducts();

            inventory.UpdateProduct(101,15,52000);
            Console.WriteLine("\nAfter Update");
            inventory.ShowProducts();
            
            inventory.DeleteProduct(102);
            Console.WriteLine("\nAfter Delete");
            inventory.ShowProducts();
        }
    }
}