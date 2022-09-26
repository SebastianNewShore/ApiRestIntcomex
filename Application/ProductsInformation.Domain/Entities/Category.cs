using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain
{
    public class Category : EntityBase<Guid>
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }
        public string categoryname { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
        public bool active { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
