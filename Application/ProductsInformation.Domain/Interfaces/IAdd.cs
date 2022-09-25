using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    ///<summary>
    ///interface that receives entity and then implements it and consumes method that receives that entity.
    ///</summary>
    public interface IAdd<TEntity>
    {
        TEntity Add(TEntity entity);
    }
}
