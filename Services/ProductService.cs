using System;
using LivrariaDoPepeu.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaDoPepeu.Data;
using Microsoft.AspNetCore.Identity;

namespace LivrariaDoPepeu.Services
{
    public class ProductService : IProductService
    {
        LDPContext _context;

        public ProductService(LDPContext context)
        {
            _context = context;
        }

        public List<Product> All() { return _context.Product.ToList(); }

        public bool Create(Product p)
        {
            try
            {
                p.created = DateTime.Now;
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Product Get(int? id)
        {
            return _context.Product.FirstOrDefault(p => p.Id == id);
        }

        
        public bool Update(Product prod)
        {
            try
            {
                if (!_context.Product.Any(p => p.Id == prod.Id)) throw new Exception("Produto não existe!");

                prod.updated = DateTime.Now;
                _context.Update(prod);
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }


        }
        public List<Product> ProductsByUserRole(string getrole)
        {
            var query1 = from product in _context.Set<Product>()
                          join user in _context.Set<IdentityUser>()
                            on product.createdById equals user.Id
                          join userRoles in _context.Set<IdentityUserRole<string>>()
                            on user.Id equals userRoles.UserId
                          join role in _context.Set<IdentityRole>()
                            on userRoles.RoleId equals role.Id
                          where role.Name.ToUpper() == getrole
                          select new Product()
                          {
                              Id = product.Id,
                              Name = product.Name,
                              Price = product.Price,
                              Synopse = product.Synopse,
                              Autor = product.Autor,
                              created = product.created,
                              updated = product.updated,
                              createdBy = product.createdBy,
                              updatedBy = product.updatedBy
                          };
            return query1.ToList();
        }
    }
}
