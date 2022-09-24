using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain
{
    class Product
    {
        public int id { get; set; }
        public string productname { get; set; }
        public int quantityperunit { get; set; }
        public decimal unitprice { get; set; }
        public int unitsinstock { get; set; }
        public int unitsonorder { get; set; }
        public int recorderlevel { get; set; }
        public bool active { get; set; }
        public int idsuppliers { get; set; }
        public int idcategory { get; set; }
    }
}
