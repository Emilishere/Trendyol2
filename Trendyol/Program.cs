using System;
using myAliasName2 = System.Collections.Generic.List<int>;

namespace Trendyol
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                EmployeeManager employeemanage = new EmployeeManager();
                employeemanage.ManageEmployee();

                ProductManager productmanager = new ProductManager();
                productmanager.ManageProduct();

                Console.WriteLine("To do shopping, first register as a customer");
                CustomerManager customermanager = new CustomerManager();
                customermanager.ManageCustomer();

                
                Order ordermanager = new Order(productmanager.ManageProducts());
                ordermanager.ManageOrder();

                

            }
            catch (Exception)
            {

                throw;
            }
            


            









        }
    }
}
