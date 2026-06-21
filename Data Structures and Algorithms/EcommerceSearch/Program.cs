using System;
namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Mobile","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories")
            };
            Console.WriteLine("Linear Search");
            Product result1 =Search.LinearSearch(products,103);
            if(result1 != null)
            {
                result1.Display();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
            Console.WriteLine("\nBinary Search");
            Product result2 =Search.BinarySearch(products,104);
            if(result2 != null)
            {
                result2.Display();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
    }
}