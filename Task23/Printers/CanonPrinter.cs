using System;
using System.Collections.Generic;
using System.Text;

namespace Task23.Printers
{
    /// <summary>
    /// Describe inkjet color printer without scan functionality 
    /// </summary>
    class CanonPrinter : Printer
    {
        public CanonPrinter() : base("Cannon", TypeOfPrinter.Inkjet, false)
        {
        }

        public override void Print(string text) 
        {
            base.Print(text);

            Console.WriteLine("(With Color)");
        }

        public override void Scan()
        {
            Console.WriteLine("The scan is impossible");
        }
    }
}
