using Labb_16___Interface_Repositories.DataStores;
using Labb_16___Interface_Repositories.Models;
using System;
using System.IO;

namespace Labb_16___Interface_Repositories
{
    internal class Runtime
    {
        public static string SaveFile { get; private set; }
        public static int CurrentProductID { get; set; }

        internal void Start()
        {
            bool runOnce = true;
            if (runOnce)
            {
                MyLists.Products.Add(new Product { Name = "Korv", Price = 15, Id = 1 });
                MyLists.Products.Add(new Product { Name = "Köttbullar", Price = 18, Id = 2 });
                MyLists.Products.Add(new Product { Name = "Bacon", Price = 10, Id = 3 });
                MyLists.Products.Add(new Product { Name = "Falukorv", Price = 25, Id = 4 });
                MyLists.Products.Add(new Product { Name = "Kyckling", Price = 30, Id = 5 });
                CurrentProductID = MyLists.Products.Count;
                runOnce = false;
            }

            var directory = Environment.CurrentDirectory;
            SaveFile = String.Format("{0}{1}", directory, "\\data.json");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            if (!File.Exists(SaveFile))
                File.Create(SaveFile);

            UserInterface.MainMenu(SaveFile);
        }
    }
}