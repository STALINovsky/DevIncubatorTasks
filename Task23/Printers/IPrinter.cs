using System;
using System.Collections.Generic;
using System.Text;

namespace Task23.Printers
{
    /// <summary>
    /// Interface for work with printers
    /// </summary>
    interface IPrinter
    {
        void Print(string text);
        void Scan();
    }
}
