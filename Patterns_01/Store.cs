using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    class Store : EntityBase
    {
        public Store(IIdGenerator idGenerator) : base(idGenerator) {}
    }
}
