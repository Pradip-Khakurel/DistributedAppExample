using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedAppExample.Shared
{
    public class Message
    {
        public string Content { get; }

        public Message(string content)
        {
            Content = content;
        }
    }
}
