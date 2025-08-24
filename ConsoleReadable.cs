using System;
using System.Collections.Generic;
using System.Linq;
namespace Interface
{
    internal class ConsoleReadable : IDoubleReadable
    {
        public string Name { get; set; } = "ConsoleReadable";

        public double ReadDouble()
        {
            Console.WriteLine("Nhap double: ");
            return double.Parse(Console.ReadLine()!);
        }

        public int ReadInt()
        {
            Console.WriteLine("Nhap int: ");
            return int.Parse(Console.ReadLine()!);
        }

        public string ReadString()
        {
            Console.WriteLine("Nhap string: ");
            return Console.ReadLine()!;
        }
    }
}
