using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContainerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumerateDirectory();
            DisplayTestFile();
        }

        static void EnumerateDirectory()
        {
            Console.WriteLine("Enumerating directory:");
            IEnumerable<string> files = Directory.EnumerateFiles("./");
            foreach (string curr in files)
            {
                Console.WriteLine("  " + curr);
            }
        }

        static void DisplayTestFile()
        {
            Console.WriteLine("Reading test.txt: ");
            byte[] data = File.ReadAllBytes("./test.txt");
            Console.WriteLine(Encoding.UTF8.GetString(data));
        }
    }
}
