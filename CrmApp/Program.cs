using System;
using System.Collections;
using System.Collections.Generic;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {

            Ui ui = new Ui();

            Customer Thanos = ui.CreateCustomer();
            Thanos.Buy();

            Product apple = ui.CreateProduct();
            Product orange = ui.CreateProduct();
            Product pear = ui.CreateProduct();


            List<Product> products = new List<Product>
            {
                apple,
                pear,
                orange
            };


            int howManyLow = 0;
            int howManyMedium = 0;
            int howManyHigh = 0;
            foreach (Product p in products)
            {
                Console.WriteLine(p.GetRange());
                if (p.GetRange() == "low") howManyLow++;
                if (p.GetRange() == "medium") howManyMedium++;
                if (p.GetRange() == "high") howManyHigh++;

            }
            Console.WriteLine($"howManyLow= {howManyLow}");
            Console.WriteLine($"howManyMedium= {howManyMedium}");
            Console.WriteLine($"howManyHigh= {howManyHigh}");

        }
    }
}