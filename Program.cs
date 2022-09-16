using System;
namespace Uppgift_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int startavgift = 300;
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer ska köra");
            int kilometer = int.Parse(Console.ReadLine());

            Console.WriteLine(startavgift + dagar * 500 - 500 + kilometer);


        }
    }

}