using System;
using System.Collections.Generic;
using System.Text;
using ProductsInformation.Domain.Interfaces;

namespace ProductsInformation.Application.Interfaces
{
    ///<summary>
    ///interface that implements the interface of the domain layer to have access to its method.
    ///</summary>
    public interface IListBaseService<TEntity, TEntityId>
    : IList<TEntity, TEntityId>{
    }
}
