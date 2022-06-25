using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06.Services
{
    internal class JSONReader
    {
        public int Reader()
        {
            var reader = File.ReadAllText("num.json");
            var json = JsonConvert.DeserializeObject<json.num>(reader);
            return Convert.ToInt32(json.N.n);
        }
    }
}
