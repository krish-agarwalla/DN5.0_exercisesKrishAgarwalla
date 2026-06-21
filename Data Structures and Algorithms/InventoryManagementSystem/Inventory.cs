using System;
using System.Collections.Generic;
namespace InventoryManagementSystem
{
    public class Inventory
    {
        Dictionary<int, Product> products =new Dictionary<int, Product>();
        public void AddProduct(Product product)
        {
            products.Add(product.ProductId,product);
            Console.WriteLine("Product Added Successfully");
        }
        public void UpdateProduct(int id,int quantity,double price)
        {
            if(products.ContainsKey(id))
            {
                products[id].Quantity =quantity;
                products[id].Price =price;
                Console.WriteLine("Product Updated");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
        public void DeleteProduct(int id)
        {
            if(products.Remove(id))
            {
                Console.WriteLine("Product Deleted");
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
        public void ShowProducts()
        {
            foreach(var item in products)
            {
                item.Value.Display();
            }
        }
    }
}