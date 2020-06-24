using System;
using System.Collections;
using System.Dynamic;
using System.Linq;

namespace LinqInvoice
{
    class Program
    {     
        static void Main(string[] args)
        {
            // initialize array of invoices
            var invoices = new[]
            {
                new Invoice(83, "Eletric sander", 7, 57.98M),
                new Invoice(24, "Power saw", 18, 99.99M),
                new Invoice(7, "Sledge hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn mower", 3, 79.59M),
                new Invoice(68, "Scredriver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M),
                new Invoice(3, "Wrench", 34, 7.50M)
           };

            //sorted by description
            var description =
                from i in invoices
                orderby i.PartDescription
                select i;
            Console.WriteLine("Sorted by description:");
            foreach (var element in description)
            {
                Console.WriteLine(element);
            }

            //sorted by price
            var price =
                from i in invoices
                orderby i.Price
                select i;
            Console.WriteLine("\nSorted by price:");
            foreach (var element in price)
            {
                Console.WriteLine(element);
            }

            //select partdesc and quantity sort by quantity
            var descQuant =
                from i in invoices
                orderby i.Quantity
                select new { i.PartDescription, i.Quantity };
            Console.WriteLine("\nSelect description and quantity, sort by quantity:");
            foreach (var element in descQuant)
            {
                Console.WriteLine(element);
            }

            //select partdesc and value(quant * price)
            var value =
                from i in invoices
                let InvoiceTotal = i.Quantity * i.Price
                orderby InvoiceTotal
                select new { i.PartDescription, InvoiceTotal };

            Console.WriteLine("\nSelect description and invoice total, sort by invoice total:");
            foreach (var element in value)
            {
                Console.WriteLine(element);
            }

            //in range 200 to 500
            var between =
              from i in invoices
              let InvoiceTotal = i.Quantity * i.Price
              where (InvoiceTotal <= 500 && InvoiceTotal >= 200)
              orderby InvoiceTotal
              select new { i.PartDescription, InvoiceTotal };

            Console.WriteLine("\nInvoice totals betwenn {200:C} and {500:C}:");
            foreach (var element in between)
            {
                Console.WriteLine(element);
            }
        }
    }
}
