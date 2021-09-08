using LivrariaDoPepeu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaDoPepeu.Services
{
    public interface IProductService
    {
        List<Product> All();
        Product Get(int? id);
        bool Create(Product p);
        bool Update(Product p);
        bool Delete(int? id);
        List<Product> ProductsByUserRole(string role);

    }
}
