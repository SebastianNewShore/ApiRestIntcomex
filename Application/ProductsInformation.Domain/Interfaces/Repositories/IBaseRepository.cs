using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity,TEntityId>
        :IAdd<TEntity>,IList<TEntity, TEntityId>, ITransaction{
    }
}
