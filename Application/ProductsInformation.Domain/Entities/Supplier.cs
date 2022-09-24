using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Supplier : EntityBase<Guid>
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string homePage { get; set; }
        public string postalCode { get; set; }
        public bool active { get; set; }
        public int idCity { get; set; }
        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
