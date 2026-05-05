using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
