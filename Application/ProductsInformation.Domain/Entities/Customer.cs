using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Customer : EntityBase<Guid>
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool Active { get; set; }
        public string PostalCode { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
