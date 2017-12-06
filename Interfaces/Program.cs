using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        private ISender sender;

        public Program(ISender sender)
        {
            this.sender = sender;
        }
        static void Main(string[] args)
        {
            //ISender sender = new SMSSender();
            ISender sender = Container.Sender;
        }
    }
}
