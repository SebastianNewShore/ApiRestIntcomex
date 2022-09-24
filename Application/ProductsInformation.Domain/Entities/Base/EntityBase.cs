using ProductsInformation.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInformation.Domain.Base
{
    public class EntityBase<T> : DomainEntity, IEntityBase<T>
    {
        public virtual T Id { get; set; } = default!;
    }
}
