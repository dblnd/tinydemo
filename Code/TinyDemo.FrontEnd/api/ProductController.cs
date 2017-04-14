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
        // GET api/<controller>
        public IEnumerable<ProductModel> Get()
        {
            ProductServiceClient productsClient = new ProductServiceClient();
            return productsClient.GetProducts();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}