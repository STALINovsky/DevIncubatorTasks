using System;
using System.Collections.Generic;
using System.Text;

namespace Task23.Printers
{
    /// <summary>
    /// Describes samsung printer with scan functionality 
    /// </summary>
    class SamsungPrinter : Printer
    {
        public SamsungPrinter() : base("Samsung", TypeOfPrinter.Laser, true)
        {
        }

        public override void Print(string text)
        {
            base.Print(text);
            Console.WriteLine("(without color)");
        }

        public override void Scan()
        {
            Console.WriteLine("The scan is Complete");
        }
    }
}
