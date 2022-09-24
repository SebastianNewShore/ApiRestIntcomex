using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Entities
{
    public class Supplier
    {
        public Guid id { get; set; }
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string homepage { get; set; }
        public string postalcode { get; set; }
        public bool active { get; set; }
        public int idcity { get; set; }
    }
}
