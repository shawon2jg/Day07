using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.name = "Mouse";
            item1.unitPrice = 300;
            item1.discount = 20;

            Item item2 = new Item();
            item2.name = "Keyboard";
            item2.unitPrice = 500;
            item2.discount = 30;

            string item1Name = item1.name;
            double item1Price = item1.unitPrice;
            double item1Discount = item1.discount;

            Console.WriteLine(item1Name + ","+ item1Price + "," + item1Discount);
            Console.ReadKey();
        }
    }
}
