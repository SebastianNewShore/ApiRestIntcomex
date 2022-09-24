using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    public interface IList<TEntity, TEntityId>
    {
        List<TEntity> ListAll();
        TEntity ListById(TEntityId entityId);
    }
}
