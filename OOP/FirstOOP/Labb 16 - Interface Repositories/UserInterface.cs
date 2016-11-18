using Labb_16___Interface_Repositories.DataStores;
using Labb_16___Interface_Repositories.Manager;
using Labb_16___Interface_Repositories.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories
{
    class UserInterface
    {
        FileProductRepository fileHandling = new FileProductRepository();
        ListProductRepository listHandling = new ListProductRepository();
        

        public static void MainMenu(string file)
        {
            ProductManager manager = new ProductManager();
            while (true)
            {
                Console.WriteLine("1. List products.");
                Console.WriteLine("2. Add product");
                Console.WriteLine("3. Get specific product");
                Console.WriteLine("4. Edit product");
                Console.WriteLine("5. Remove product");
                Console.WriteLine("6. Quit");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        manager.PrintAllProducts();
                        break;
                    case ConsoleKey.D2:
                        manager.CreateProduct();
                        break;
                    case ConsoleKey.D3:
                        manager.PrintSpecificProduct();
                        break;
                    case ConsoleKey.D4:
                        manager.UpdateProduct();
                        break;
                    case ConsoleKey.D5:
                        manager.RemoveProduct();
                        break;
                    case ConsoleKey.D6:
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Wrong input."); break;
                }
            }
        }

        public static Product CreateProduct()
        {
            Product newProduct = new Product();

            Console.Write("Product Name: ");
            newProduct.Name = Console.ReadLine();

            Console.Write("Product Price: ");
            newProduct.Price = int.Parse(Console.ReadLine());

            Runtime.CurrentProductID = Runtime.CurrentProductID + 1;
            newProduct.Id = Runtime.CurrentProductID;

            return newProduct;
        }
    }
}
