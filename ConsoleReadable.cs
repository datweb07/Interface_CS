using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ConsoleReadable : IReadable
    {
        public int ReadInt()
        {
            return int.Parse(Console.ReadLine()!);
        }

        public string ReadString()
        {
            return Console.ReadLine()!;
        }
    }
}
