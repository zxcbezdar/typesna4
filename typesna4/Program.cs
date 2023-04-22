using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string text = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности.";
        Console.WriteLine($"ASCII: {Encoding.ASCII.GetByteCount(text)} bytes");
        Console.WriteLine($"UTF-7: {Encoding.UTF7.GetByteCount(text)} bytes");
        Console.WriteLine($"UTF-8: {Encoding.UTF8.GetByteCount(text)} bytes");
        Console.WriteLine($"UTF-16: {Encoding.Unicode.GetByteCount(text)} bytes");
        Console.WriteLine($"UTF-32: {Encoding.UTF32.GetByteCount(text)} bytes");
    }
}
