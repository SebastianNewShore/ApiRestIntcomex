using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class City : EntityBase<Guid>
    {
        public City()
        {
            Customer = new HashSet<Customer>();
            Employee = new HashSet<Employee>();
            Order = new HashSet<Order>();
            Supplier = new HashSet<Supplier>();
        }
        public string Name { get; set; }
        public bool Active { get; set; }
        public Guid IdRegion { get; set; }

        public virtual Region IdRegionNavigation { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
