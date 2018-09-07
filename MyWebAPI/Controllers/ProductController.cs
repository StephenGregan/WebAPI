using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository pr = new ProductRepository();

        public IEnumerable<Product> Get()
        {
            return pr.FindAll();
        }

        public Product Get(string id)
        {
            return pr.Find(id);
        }
    }
}
