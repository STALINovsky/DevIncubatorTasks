using System;
using Task25.Products;

namespace Task25
{
    class Program
    {
        /// <summary>
        /// method to initialize Rack
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rack">rack to init</param>
        /// <param name="count">count of products </param>
        /// <param name="constructor">factory method </param>
        public static void FillRack<T>(Rack<T> rack, int count, Func<T> constructor) where T : Product
        {
            for (int i = 0; i < count; i++)
            {
                rack.AddProduct(constructor.Invoke());
            }
        }


        static void Main(string[] args)
        {
            //creating racks
            Rack<Bread> rackBread1 = new Rack<Bread>();
            Rack<Bread> rackBread2 = new Rack<Bread>();
            Rack<Bread> rackBread3 = new Rack<Bread>();

            Rack<Milk> rackMilk1 = new Rack<Milk>();
            Rack<Milk> rackMilk2 = new Rack<Milk>();

            Rack<Pasta> rackPasta1 = new Rack<Pasta>();

            Rack<Porridge> rackPorridge1 = new Rack<Porridge>();

            //filling racks
            FillRack(rackBread1,30,() => new Bread("White bread"));
            FillRack(rackBread2,40,() => new Bread("black bread"));
            FillRack(rackBread3,40,() => new Bread("gray bread"));

            FillRack(rackMilk1,40, () => new Milk("cow's milk"));
            FillRack(rackMilk1,45, () => new Milk("goat milk"));

            FillRack(rackPasta1, 70, () => new Pasta("Antonio Margheriti"));

            FillRack(rackPorridge1, 60, () => new Porridge("buckwheat"));
            
            //show information about products
            Console.WriteLine($"Store has :\n" +
                              $"bread - {Rack<Bread>.CountOfProducts}\n" +
                              $"milk - {Rack<Milk>.CountOfProducts}\n" +
                              $"pasta - {Rack<Pasta>.CountOfProducts}\n" +
                              $"porridge - {Rack<Porridge>.CountOfProducts}");



        }
    }
}
