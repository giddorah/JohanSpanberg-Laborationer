using Labb_16___Interface_Repositories.DataStores;
using Labb_16___Interface_Repositories.Interfaces;
using Labb_16___Interface_Repositories.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories
{
    class FileProductRepository : IProductRepository
    {
        public void Add(Product newProduct)
        {
            string jsonString = JsonConvert.SerializeObject(newProduct);
            File.AppendAllText(Runtime.SaveFile, jsonString);
        }

        public void Delete(int id)
        {

            string jsonFromFile = File.ReadAllText(Runtime.SaveFile);
            string jsonString = JsonConvert.SerializeObject(MyLists.Products);

            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            var productToDelete = productList.SingleOrDefault(product => product.Id == id);

            productList.Remove(productToDelete);

            jsonString = JsonConvert.SerializeObject(productList);
            File.WriteAllText(Runtime.SaveFile, jsonString);
        }

        public void Get(int id)
        {
            string jsonFromFile = File.ReadAllText(Runtime.SaveFile);
            string jsonString = JsonConvert.SerializeObject(MyLists.Products);

            Product[] productList = JsonConvert.DeserializeObject<Product[]>(jsonString);

            var productToGet = productList.SingleOrDefault(product => product.Id == id);

            Console.WriteLine("File: {0}, {1}, ID: {2}", productToGet.Name, productToGet.Price, productToGet.Id);

        }

        public void GetAll()
        {
            string jsonFromFile = File.ReadAllText(Runtime.SaveFile);
            string jsonString = JsonConvert.SerializeObject(MyLists.Products);

            Product[] productList = JsonConvert.DeserializeObject<Product[]>(jsonString);

            foreach (var product in productList)
            {
                Console.WriteLine("File: {0}, {1}, ID: {2}", product.Name, product.Price, product.Id);
            }
            File.WriteAllText(Runtime.SaveFile, jsonString);
        }

        public void Update(Product updatedProduct)
        {
            string jsonFromFile = File.ReadAllText(Runtime.SaveFile);
            string jsonString = JsonConvert.SerializeObject(MyLists.Products);

            Product[] productList = JsonConvert.DeserializeObject<Product[]>(jsonString);

            File.WriteAllText(Runtime.SaveFile, jsonString);
        }
    }
}
