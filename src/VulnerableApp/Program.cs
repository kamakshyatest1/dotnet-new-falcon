
using System;
using Newtonsoft.Json;

namespace VulnerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var json = JsonConvert.SerializeObject(new { message = "Hello, World!" });
            Console.WriteLine(json);
        }
    }
}
