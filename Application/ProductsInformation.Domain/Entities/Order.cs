using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Order : EntityBase<Guid>
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }
        public DateTime OrderDate { get; set; }
        public bool RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipPostalCode { get; set; }
        public Guid IdCity { get; set; }
        public Guid IdCustomers { get; set; }
        public Guid IdEmployees { get; set; }
        public Guid IdShippers { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual Customer IdCustomersNavigation { get; set; }
        public virtual Employee IdEmployeesNavigation { get; set; }
        public virtual Shipper IdShippersNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
