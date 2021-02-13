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
            var jsonText = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}person.json");

            var person = JsonConvert.DeserializeObject<Person>(jsonText);

            Console.WriteLine(CheckedAge(person.Age));
            Console.ReadKey();
        }
        static bool CheckedAge(int age)
        {
            return age > 18;
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Person
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("fullname")]
        public string Fullname { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }

    }
}
