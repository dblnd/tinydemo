using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TinyDemo.API.Client;
using TinyDemo.Models;

namespace TinyDemo.FrontEnd.api
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            ProductServiceClient productsClient = new ProductServiceClient();
            return productsClient.GetProducts();
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get(int id)
        {
            ProductServiceClient productsClient = new ProductServiceClient();
            return productsClient.GetProductsByCategoryId(id);
        }
    }
}