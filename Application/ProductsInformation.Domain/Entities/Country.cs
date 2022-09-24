using ProductsInformation.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Country : EntityBase<Guid>
    {
        public Country()
        {
            Region = new HashSet<Region>();
        }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Region> Region { get; set; }
    }
}
