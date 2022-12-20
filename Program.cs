#define Test
#define TestImplement 

using System.Diagnostics;
using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        TestImplement();
        WriteLine("Hello World!");
    }

    [Conditional("Test123")]
    static void Test()
    {
        WriteLine("Test");
    }

    [Conditional("TestImplement")]
    static void TestImplement()
    {
        WriteLine("TestImplement");
    }
}
