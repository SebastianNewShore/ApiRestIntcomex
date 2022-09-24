using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    public interface ITransaction
    {
        void SaveChanges();
    }
}
