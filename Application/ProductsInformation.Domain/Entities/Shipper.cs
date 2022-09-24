using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Shipper : EntityBase<Guid>
    {
        public Shipper()
        {
            Order = new HashSet<Order>();
        }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
