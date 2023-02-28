
using System.ComponentModel.DataAnnotations;

class ClassProgramming
{
    public static void Display(int b, double mark, string name)
    {

        Console.WriteLine("Enter your age");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is = {b}, Your {mark}, Your {name}");
    }
    public static void Main(string[] args)
    {
        Display(5, 55.6, "ABC");

    }
}