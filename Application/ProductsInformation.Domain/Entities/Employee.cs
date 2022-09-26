using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Employee : EntityBase<Guid>
    {
        public Employee()
        {
            Order = new HashSet<Order>();
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Adress { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public string ReportsTo { get; set; }
        public string PostalCode { get; set; }
        public Guid IdCity { get; set; }
        public bool Active { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
