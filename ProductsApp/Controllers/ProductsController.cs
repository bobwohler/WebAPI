using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        #region Model Data
        // Internal product array to serve as the datastore.
        Product[] _products = new Product[]
        {
            new Product {Id=1, Category="Groceries", Name="Tomato Soup", Price=1},
            new Product {Id=2, Category="Toys", Name="Yo-yo", Price=3.75M},
            new Product {Id=3, Category="Hardware", Name="Hammer", Price=16.99M}
        };
        #endregion

        #region API
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = _products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        #endregion


    }
}
