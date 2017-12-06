using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public static class Container
    {
        public static ISender Sender
        {
            get
            {
                return new SMSSender();
            }
        }
    }
}
