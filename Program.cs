namespace Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = new DatabaseReadable();
            Run(reader);
        }

        public static void Run(IDoubleReadable reader)
        {
            reader.PrintNameExtensionMethod(); // Extension method

            IDoubleReadable.Print(reader);

            Console.WriteLine($"Reader name: {reader.Name}");

            int n = reader.ReadInt();

            string s = reader.ReadString();

            Console.WriteLine($"int: {n}, string: {s}");
        }
    }
}
