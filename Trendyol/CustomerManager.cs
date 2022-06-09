using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class CustomerManager
    {
        public void ManageCustomer()
        {
            Customer customer1 = new Customer();
            Console.WriteLine("Enter Customer Name:");
            customer1.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Surname:");
            customer1.Surname = Console.ReadLine();
            Console.WriteLine("Enter Customer's Father Name:");
            customer1.Patronymic = Console.ReadLine();

            Console.WriteLine("Enter customer email");
            customer1.Email = Console.ReadLine();

            Console.WriteLine("Enter password");
            customer1.Password = Console.ReadLine();

            Console.WriteLine("Enter customer phone number:");
            string response = string.Empty;
            do
            {
                string item = Console.ReadLine();
                customer1.AddPhones(item);
                Console.WriteLine("Do you want to add another one? y-yes/n-no");
                response = Console.ReadLine();
            } while (response == "y");

            Console.WriteLine("Enter customer address:");
            string responseAddress = string.Empty;
            do
            {
                string item = Console.ReadLine();
                customer1.AddPhones(item);
                Console.WriteLine("Do you want to add another one? y-yes/n-no");
                responseAddress = Console.ReadLine();
            } while (responseAddress == "y");
            customer1.WritePersonInformation();
        }
    }
}
