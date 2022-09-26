using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    ///<summary>
    ///interface that receives data type sent from the implementation, for the creation of the Id attribute.
    ///</summary>
    public interface IEntityBase<T>
    {
        T Id { get; set; }
    }
}
