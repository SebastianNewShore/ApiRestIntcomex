using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces.Repositories
{
    public interface IListBaseRepository<TEntity,TEntityId>
        :IList<TEntity, TEntityId>, ITransaction{
    }
}
