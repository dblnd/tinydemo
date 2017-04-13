﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using TinyDemo.Models;

namespace TinyDemo.API.Client
{
    public class ProductsServiceClient
    {
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> result = new List<ProductModel>();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage apiResponse = client.GetAsync("http://localhost:60648/api/products").Result)
                {

                    if (apiResponse.StatusCode != HttpStatusCode.OK)
                    {
                        throw new InvalidOperationException(string.Format("Failure while retrieving products. {1}", apiResponse.StatusCode));
                    }

                    result = apiResponse.Content.ReadAsAsync<List<ProductModel>>(new[] { new  JsonMediaTypeFormatter() }).Result;

                    return result;
                }
            }
        }
    }
}
