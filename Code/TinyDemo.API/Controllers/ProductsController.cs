using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TinyDemo.API;
using TinyDemo.Models;

namespace TinyDemo.API.Controllers
{
    public class ProductsController : ApiController
    {
        private AdventureWorksModel db = new AdventureWorksModel();

        public List<ProductModel> GetProducts([FromUri] int categoryId)
        {
            using (AdventureWorksModel context = new AdventureWorksModel())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.Products.Where(p => p.ProductCategoryID.Value.Equals(categoryId)).Select(p => new ProductModel() { ProductID = p.ProductID, Name = p.Name}).ToList();
            }
        }

        public List<ProductModel> GetProducts()
        {
            using (AdventureWorksModel context = new AdventureWorksModel())
            {
                context.Configuration.ProxyCreationEnabled = false;
                return context.Products.Select(p => new ProductModel() { ProductID = p.ProductID, Name = p.Name }).ToList();
            }
        }
    }
}