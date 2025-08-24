namespace Interface
{
    public interface IReadable
    {
        string Name { get; set; }
        int ReadInt();
        string ReadString();

        static void IDoubleReadable()
        {

        }

        static void Print(IDoubleReadable readable)
        {
            Console.WriteLine($"Hello {readable.Name} from IReadable");
        }
    }
}
