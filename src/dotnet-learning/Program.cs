// See https://aka.ms/new-console-template for more information

using System.Text;

namespace dotnet_learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var data = Console.ReadLine();
            var sb = new StringBuilder();
            sb.Append("Hello World! Меня зовут ").Append(data);
            Console.WriteLine(sb.ToString());
        }
    }
}