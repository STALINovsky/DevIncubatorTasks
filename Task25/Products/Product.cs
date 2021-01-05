using System;
using System.Collections.Generic;
using System.Text;

namespace Task25
{
    /// <summary>
    /// base class of products
    /// </summary>
    public abstract class Product
    {
        protected Product()
        {
            
        }

        protected Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
