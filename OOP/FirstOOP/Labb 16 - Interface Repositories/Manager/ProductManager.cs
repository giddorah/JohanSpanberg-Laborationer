using Labb_16___Interface_Repositories.DataStores;
using Labb_16___Interface_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories.Manager
{
    class ProductManager
    {
        private IProductRepository listProductRepository = new ListProductRepository();
        private IProductRepository fileProductRepository = new FileProductRepository();

        public void CreateProduct()
        {
            var newProduct = UserInterface.CreateProduct();
            listProductRepository.Add(newProduct);
            fileProductRepository.Add(newProduct);
        }

        public void RemoveProduct()
        {
            listProductRepository.GetAll();

            Console.Write("Which product-ID would you like to delete: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Done. Removed {0} with the price {1} SEK and ID {2}.", MyLists.Products[id-1].Name, MyLists.Products[id-1].Price, MyLists.Products[id-1].Id);
            listProductRepository.Delete(id);
            fileProductRepository.Delete(id);
        }

        public void PrintSpecificProduct()
        {
            listProductRepository.GetAll();
            Console.Write("Which product-ID would you like to get: ");
            int id = int.Parse(Console.ReadLine());

            listProductRepository.Get(id);
            fileProductRepository.Get(id);
            Console.ReadLine();
        }

        public void PrintAllProducts()
        {
            listProductRepository.GetAll();
            fileProductRepository.GetAll();
            Console.ReadLine();
        }

        public void UpdateProduct()
        {
            listProductRepository.GetAll();
            Console.Write("Which product would you like to update: ");
            int userEditChoice = int.Parse(Console.ReadLine());

            var updatedProduct = MyLists.Products[userEditChoice - 1];

            listProductRepository.Update(updatedProduct);
            fileProductRepository.Update(updatedProduct);
        }
    }
}
