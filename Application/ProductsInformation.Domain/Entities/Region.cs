using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Region : EntityBase<Guid>
    {
        public Region()
        {
            City = new HashSet<City>();
        }
        public string name { get; set; }
        public bool Active { get; set; }
        public int IdCountry { get; set; }
        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
