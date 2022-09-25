using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Interfaces.Repositories
{
    public interface IAddBaseRepository<TEntity,TEntityId>
        :IAdd<TEntity>,ITransaction{
    }
}
