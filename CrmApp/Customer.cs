using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Customer
    {
        private string name;
        private int id;
        private List<int> basket = new List<int>();

        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Money { get; set; }

        public Customer()
        {

        }
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public override string ToString()
        {
            // preferrable way using $
            return $"Name= {Name} Id= {Id} Money= {Money}";

        }

        public void Buy()
        {
            Console.WriteLine("Give the product code");
            int code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give the price");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give the money");
            Money = Decimal.Parse(Console.ReadLine());

            if (Money >= price)
            {
                Money -= price;
                Console.WriteLine($"Left in your wallet: {Money}");
                basket.Add(1);
                Console.WriteLine( $"Purchased item with code: {code}");
            }
            else
            {
                Console.WriteLine("Not enough money!");
            }
        }
    }
}