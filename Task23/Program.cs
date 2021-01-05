using System;
using System.Collections.Generic;
using Task23.Printers;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            //create printers
            List<IPrinter> printers = new List<IPrinter>()
            {
                new CanonPrinter(),
                new SamsungPrinter(),
            };

            //checking work with printers
            foreach (var printer in printers)
            {
                Console.WriteLine(printer.ToString());

                Console.WriteLine("Enter text to print");
                string textToPrint = Console.ReadLine();

                //trying to print and scan 
                printer.Print(textToPrint);
                printer.Scan();
            }

        }
    }
}
