using ProductsInformation.Domain.Base;
using ProductsInformation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain
{
    public class Product : EntityBase<Guid>
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }
        public string productName { get; set; }
        public int quantityPerunit { get; set; }
        public decimal unitPrice { get; set; }
        public int unitsinStock { get; set; }
        public int unitsonOrder { get; set; }
        public int recorderLevel { get; set; }
        public bool active { get; set; }
        public Guid idSuppliers { get; set; }
        public Guid idCategory { get; set; }
        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Supplier IdSuppliersNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
