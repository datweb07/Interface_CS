using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class DatabaseReadable : IDoubleReadable
    {
        public string Name { get ; set; } = "DatabaseReadable";

        public double ReadDouble()
        {
            return 999;
        }

        public int ReadInt()
        {
            return 99;
        }

        public string ReadString()
        {
            return "DAT";
        }
    }
}
