using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal static class ReadableExtensionMethod
    {
        public static void PrintNameExtensionMethod(this IDoubleReadable readable)
        {
            Console.WriteLine($"Hello {readable.Name} from extension method");
        }
    }
}
