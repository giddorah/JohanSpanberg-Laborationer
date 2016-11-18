using Labb_16___Interface_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories.DataStores
{
    class MyLists
    {
        private static List<Product> products;

        public static List<Product> Products
        {
            get
            {
                if (products == null)
                    products = new List<Product>();

                return products;
            }
        }



    }
}

