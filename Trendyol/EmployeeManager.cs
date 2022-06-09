using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class EmployeeManager
    {
        public void ManageEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Name:");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Surname:");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Enter Employee's Father Name:");
            employee.Patronymic = Console.ReadLine();

            Console.WriteLine("Enter Employee email");
            employee.Email = Console.ReadLine();

            Console.WriteLine("Enter password");
            employee.Password = Console.ReadLine();

            Console.WriteLine("Enter Employee phone number:");
            string response2 = string.Empty;
            do
            {
                string item = Console.ReadLine();
                employee.AddPhones(item);
                Console.WriteLine("Do you want to add another one? y-yes/n-no");
                response2 = Console.ReadLine();
            } while (response2 == "y");

            Console.WriteLine("Enter Employee address:");
            string responseAddress2 = string.Empty;
            do
            {
                string item = Console.ReadLine();
                employee.AddPhones(item);
                Console.WriteLine("Do you want to add another one? y-yes/n-no");
                responseAddress2 = Console.ReadLine();
            } while (responseAddress2 == "y");
            employee.WritePersonInformation();
            Console.WriteLine("Employee has been registered succesfully");
        }
    }
}
