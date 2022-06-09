using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Order
    {

        private readonly List<Product> Products;
        public Order()
        {

        }

        
        public Order(List<Product> Products)
        {
            this.Products = Products;
        }
        public void ManageOrder()
        {
            List<Order> orderManager = new List<Order>();
         
            string ask = string.Empty;
            int number = 1;
            do
            {
                Console.WriteLine($"Enter the ID of the product you want to order-{number}");
                int Productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of the products:");
                int Count = Convert.ToInt32(Console.ReadLine());
                Order order1 = new Order();
                {
                    order1.Id = number;
                    order1.ProductId = Productid;
                    order1.count = Count;
                    
                }

                orderManager.Add(order1);

                
                number++;

                Console.WriteLine("Do you want to order more? y-yes/n-no");
                ask = Console.ReadLine();

            } while (ask=="y");



            
            for (int i = 0; i < orderManager.Count; i++)
            {
                for (int j = 0; j < Products.Count; j++)
                {
                    if (orderManager[i].ProductId == Products[j].Id)
                    {
                        Console.WriteLine($" Oder-Id: {orderManager[i].Id}, Product-name: {Products[j].Price}, Count: {orderManager[i].count} TotalAmount:{orderManager[i].count * Products[j].Price}");
                    }
                }

            }

        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int count { get; set; } //sifaris verilen productin sayi
        public decimal Totalamount { get; set; }
        public decimal Total(int Ordercount, decimal ProductPrice)
        {
            decimal Totalamount = Ordercount * ProductPrice;
            return Totalamount;
        }
        public override string ToString()

        {
            return $"Product -- {ProductId} + number of products -- {count} + The total amount needed to be paid -- {Totalamount}".ToString();
        }
    }
}
