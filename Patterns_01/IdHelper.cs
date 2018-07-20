using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_01
{
    public static class IdHelper
    {
        public static long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
