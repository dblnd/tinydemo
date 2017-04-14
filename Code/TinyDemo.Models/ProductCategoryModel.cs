using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyDemo.Models
{
    public class ProductCategoryModel
    {
        public int ProductCategoryID { get; set; }

        public int? ParentProductCategoryID { get; set; }

        public string Name { get; set; }

    }
}