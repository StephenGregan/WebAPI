using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAPI.Models
{
    public class ProductRepository : IProduct
    {
        private List<Product> listProducts = new List<Product>();

        public ProductRepository()
        {
            listProducts.Add(new Product { Id = "1", Name = "Stephen", Price = 200} );
            listProducts.Add(new Product { Id = "1", Name = "John", Price = 400 } );
            listProducts.Add(new Product { Id = "1", Name = "Kevin", Price = 600 } );
        }

        public Product Find(string id)
        {
            return listProducts.Single(p => p.Id.Equals(id));
        }

        public IEnumerable<Product> FindAll()
        {
            return listProducts;
        }
    }
}