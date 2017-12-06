using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SMSSender: ISender
    {
        public string PrepareMessage(string message)
        {
            return message.Trim();
        }

        public void SendMssage(string message)
        {
            //отправка сообщения.
        }
    }
}
