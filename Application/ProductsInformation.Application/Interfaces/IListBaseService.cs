using System;
using System.Collections.Generic;
using System.Text;
using ProductsInformation.Domain.Interfaces;

namespace ProductsInformation.Application.Interfaces
{
    public interface IListBaseService<TEntity, TEntityId>
    : IList<TEntity, TEntityId>{
    }
}
