using Labb_16___Interface_Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_16___Interface_Repositories.Interfaces
{
    interface IProductRepository
    {
        void Get(int id);
        void GetAll();
        void Update(Product updatedProduct);
        void Delete(int id);
        void Add(Product newProduct);
    }
}
