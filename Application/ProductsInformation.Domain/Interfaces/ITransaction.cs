using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    ///<summary>
    ///interface for saving information
    ///</summary>
    public interface ITransaction
    {
        void SaveChanges();
    }
}
