using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            CustomerOption custOpt = new CustomerOption
            {
                FirstName = "Maria",
                LastName = "Pentagiotissa",
                Address = "Athens",
                Email = "maria@gmail.com",
            };

            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custManager = new CustomerManagement(db);

            //testing the creation of a customer
            Customer customer = custManager.CreateCustomer(custOpt);
            Console.WriteLine($"Id= {customer.Id} Address= {customer.Address}");

            //testing reading a customer
            Customer cx = custManager.FindCustomerById(2);
            Console.WriteLine($"Id= {cx.Id} Address= {cx.Address}");

            //testing updating
            CustomerOption custChangeAdress = new CustomerOption
            {
                Address = "Lamia"
            };

            Customer c2 = custManager.Update(custChangeAdress, 2);
            Console.WriteLine($"Id= {cx.Id} Address= {cx.Address}");

            //testing deletion

            bool result = custManager.DeleteCustomerById(2);
            Console.WriteLine($"Result = {result}");
            Customer cx2 = custManager.FindCustomerById(2);
            if (cx2 != null)
            {
                Console.WriteLine(
                $"Id= {cx2.Id} Name= {cx2.FirstName} Address= {cx2.Address}");

            }
            else
            {
                Console.WriteLine("not found");
            }



        }
    }
}