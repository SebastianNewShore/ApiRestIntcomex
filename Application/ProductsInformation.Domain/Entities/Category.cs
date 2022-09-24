using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain
{
    public class Category
    {
        public Guid id { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
        public bool active { get; set; }
    }
}
