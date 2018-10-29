using System;

namespace JsonParseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            Console.WriteLine("Beginning parsing");
            var beginning = DateTime.Now;
            parser.ParseReviews();
            var end = DateTime.Now;
            Console.WriteLine("Done");
            var time = end - beginning;
            Console.WriteLine($"Time: {time}");
            Console.ReadLine();
        }
    }
}
