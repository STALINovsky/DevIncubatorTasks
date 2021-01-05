using System.Collections.Generic;

namespace Task25
{
    /// <summary>
    /// Rack to containing products
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Rack<T> where T : Product
    {
        private readonly List<T> _productList = new List<T>();
        public IReadOnlyList<T> Products => _productList;

        public static int CountOfProducts { get; private set; } = 0;

        public void AddProduct(T product)
        {
            _productList.Add(product);
            CountOfProducts++;
        }
    }
}