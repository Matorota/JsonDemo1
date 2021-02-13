using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var location = new Location
            {
                X = 5,
                Y = 6
            };

            var json = JsonConvert.SerializeObject(location);

            File.WriteAllText($"{AppDomain.CurrentDomain.BaseDirectory}location.json",json);
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
