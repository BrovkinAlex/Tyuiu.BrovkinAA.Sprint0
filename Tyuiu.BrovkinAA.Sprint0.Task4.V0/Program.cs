using Tyuiu.BrovkinAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BrovkinAA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(3, 7));
            Console.WriteLine(DataService.Subtraction(8, 2));
            Console.WriteLine(DataService.Multiplication(4, 4));
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
