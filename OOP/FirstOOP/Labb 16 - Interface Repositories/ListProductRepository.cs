using Labb_16___Interface_Repositories.DataStores;
using Labb_16___Interface_Repositories.Interfaces;
using Labb_16___Interface_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories
{
    class ListProductRepository : IProductRepository
    {
        public void Add(Product newProduct)
        {
            MyLists.Products.Add(newProduct);
        }

        public void Delete(int id)
        {
            var productToDelete = MyLists.Products.SingleOrDefault(product => product.Id == id);

            MyLists.Products.Remove(productToDelete);

            Console.ReadLine();
        }

        public void Get(int id)
        {
            var productToGet = MyLists.Products.SingleOrDefault(product => product.Id == id);

            Console.WriteLine("List: The product with ID {0} is: {1} - {2} SEK.", productToGet.Id, productToGet.Name, productToGet.Price);
        }

        public void GetAll()
        {
            Console.WriteLine("Current products is: ");
            foreach (var product in MyLists.Products)
            {
                Console.WriteLine("ID: {0} - {1} - {2} SEK.", product.Id, product.Name, product.Price);
            }
        }

        public void Update(Product updatedProduct)
        {
            Console.Clear();
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change price");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;
            

            Console.Clear();
            Console.WriteLine("Product: {0}. Price {1}", updatedProduct.Name, updatedProduct.Price);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    updatedProduct.Name = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New price: ");
                    updatedProduct.Price = int.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
