using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces
{
    ///<summary>
    ///interface that receives entity and at the time of implementation, methods that refer to that entity are consumed.
    ///</summary>
    public interface IList<TEntity, TEntityId>
    {
        List<TEntity> ListAll();
        TEntity ListById(TEntityId entityId);
    }
}
