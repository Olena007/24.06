using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06.Models
{
    internal class Logger
    {
        public string Name { get; set; }

        public string DateTime { get; set; }

        public string Message { get; set; }

        public Logger(string name, string datetime, string message)
        {
            this.Name = name;
            this.DateTime = datetime;
            this.Message = message;
        }
    }
}
