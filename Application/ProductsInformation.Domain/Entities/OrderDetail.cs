using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class OrderDetail : EntityBase<Guid>
    {
        public Guid IdOrders { get; set; }
        public Guid IdProducts { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Order IdOrdersNavigation { get; set; }
        public virtual Product IdProductsNavigation { get; set; }
    }
}
