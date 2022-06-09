using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class ProductManager
    {
        List<Product> productList = new List<Product>();
        public void ManageProduct()
        {
            
            
            string ask = string.Empty;
            int idcode = 1;
            do
            {
                Console.WriteLine($"Enter the title of the product with the id {idcode}");
                string title = Console.ReadLine();
                Console.WriteLine($"Enter the price of the product with the id {idcode}");
                decimal price2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"Enter the type of the product with the id {idcode}");
                string type = Console.ReadLine();
                Console.WriteLine($"Enter the description of the product with the id {idcode}");
                string desc = Console.ReadLine();
                Product product1 = new Product();
                {
                    product1.Id = idcode;
                    product1.title = title;
                    product1.Price = price2;
                    product1.Type = type;
                    product1.Description = desc;
                    string response = string.Empty;
                    Console.WriteLine("what do you have as a free item by the product");
                    string item = Console.ReadLine();
                    string response2 = string.Empty;
                    string response3 = string.Empty;
                    do
                    {
                        Console.WriteLine("Description of your product right now:");
                        Console.WriteLine(product1.Description);
                        Console.WriteLine("Do you want to do some changes? y-yes, n-no");
                        response3 = Console.ReadLine();
                        if (response3 == "y")
                        {
                            Console.WriteLine("Write description you want:");
                            string edition = Console.ReadLine();
                            product1.edit_Description(edition);
                        }
                    } while (response2 == "y");
                    productList.Add(product1);
                    idcode++;
                    Console.WriteLine("Do you want to add more product? y-yes, n-no");
                    ask = Console.ReadLine();
                }
            } while (ask == "y");
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);
            }
        }
       
        public List<Product> ManageProducts()
        {
            return productList;
        }
    }
}
