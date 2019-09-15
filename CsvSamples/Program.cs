using System;
using System.Linq;

namespace CsvSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            BulkDataSource bulkDataSource = new BulkDataSource();
            var products = bulkDataSource.ReadAllProducts();

            foreach (var p in products)
            {
                Console.WriteLine(p.ProductName);
            }

            Console.WriteLine(products.Count());

            Console.ReadLine();
        }
    }
}
