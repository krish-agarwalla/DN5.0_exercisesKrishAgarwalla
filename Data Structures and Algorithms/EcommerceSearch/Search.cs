using System;
namespace EcommerceSearch
{
    public class Search
    {
        public static Product LinearSearch(Product[] products,int id)
        {
            for(int i=0;i<products.Length;i++)
            {
                if(products[i].ProductId == id)
                {
                    return products[i];
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products,int id)
        {
            int left = 0;
            int right =products.Length - 1;
            while(left <= right)
            {
                int mid =(left + right) / 2;
                if(products[mid].ProductId== id)
                {
                    return products[mid];
                }
                else if(products[mid].ProductId< id)
                {
                    left =mid + 1;
                }
                else
                {
                    right =mid - 1;
                }
            }
            return null;
        }
    }
}