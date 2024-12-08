using MyLibrary;

namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Write("Hello Writer");
            //Console.WriteLine("Hello, World!");
        }
    }
}
