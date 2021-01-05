using System;
using System.Collections.Generic;
using System.Text;

namespace Task23.Printers
{

    /// <summary>
    /// Base class of printers
    /// </summary>
    public abstract class Printer : IPrinter
    {
        public string Name { get; set; }
        public TypeOfPrinter TypeOfPrinter { get; protected set; }
        protected bool HasScanFunctionality { get; set; }

        protected Printer(string name,TypeOfPrinter typeOfPrinter, bool hasScanFunctionality)
        {
            Name = name;
            HasScanFunctionality = hasScanFunctionality;
            TypeOfPrinter = typeOfPrinter;
        }

        //default implementation of print
        public virtual void Print(string text)
        {
            Console.Write(text);
        }

        public abstract void Scan();

        public override string ToString()
        {
            return $"Name: {Name}, type: {TypeOfPrinter}, Can scan: {HasScanFunctionality}";
        }
    }
}
