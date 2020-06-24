using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01___300295374
{
    /* Student: Jose Claudio G. Vanni
     * ID: 300295374
     * */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    string partNumber, partDesc;
                    int quant;
                    decimal price;


                    Console.WriteLine("Please enter part Number: ");
                    partNumber = Console.ReadLine();
                    Console.WriteLine("Please enter part description: ");
                    partDesc = Console.ReadLine();
                    Console.WriteLine("Please enter quantity: ");
                    quant = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter Price: ");
                    price = decimal.Parse(Console.ReadLine());

                    Invoice invoice = new Invoice(partNumber, partDesc, quant, price);

                    Console.WriteLine("Original invoice information ");
                    Console.WriteLine($"Part number: {invoice.PartNumber}");
                    Console.WriteLine($"Description: {invoice.PartDesc}");
                    Console.WriteLine($"Quantity: {invoice.getQuantity}");
                    Console.WriteLine($"Price: {invoice.getUnitPrice:C}");
                    Console.WriteLine($"Invoice amount: {invoice.GetInvoiceAmount():C}");
                    Console.ReadLine();

                    Console.WriteLine("Another invoice or type quit to exit");
                    string input = Console.ReadLine();
                    if (input == "quit")
                    { 
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter part Number: ");
                        partNumber = Console.ReadLine();
                        Console.WriteLine("Please enter part description: ");
                        partDesc = Console.ReadLine();
                        Console.WriteLine("Please enter quantity: ");
                        quant = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter Price: ");
                        price = decimal.Parse(Console.ReadLine());
                        Console.ReadLine();
                    }
                       
                    

                    Console.WriteLine("Updated invoice information ");
                    Console.WriteLine($"Part number: {invoice.PartNumber}");
                    Console.WriteLine($"Description: {invoice.PartDesc}");
                    Console.WriteLine($"Quantity: {invoice.getQuantity}");
                    Console.WriteLine($"Price: {invoice.getUnitPrice:C}");
                    Console.WriteLine($"Invoice amount: {invoice.GetInvoiceAmount():C}");                    
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }    
        }
    }
}
