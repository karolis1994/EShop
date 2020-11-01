using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Domain
{
    public abstract class Entity
    {
        public virtual long Id { get; set; }
    }
}
