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
        public string productname { get; set; }
        public int quantityperunit { get; set; }
        public decimal unitprice { get; set; }
        public int unitsinstock { get; set; }
        public int unitsonorder { get; set; }
        public int recorderlevel { get; set; }
        public bool active { get; set; }
        public Guid idsuppliers { get; set; }
        public Guid idcategory { get; set; }
        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Supplier IdSuppliersNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
