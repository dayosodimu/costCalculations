using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // User to enter floor width
                Console.WriteLine("Enter floor width");
                int InchWidth = Convert.ToInt32(Console.ReadLine());

                // User to enter floor lenght
                Console.WriteLine("Enter floor lenght");
                int InchLenght = Convert.ToInt32(Console.ReadLine());

                // Cost per 1 unit
                decimal totalWidthinFeet = (InchWidth / 5);
                decimal totalLengthinFeet = (InchLenght / 15);

                var totalArea = totalLengthinFeet * totalWidthinFeet;
                Console.WriteLine("The total area cost is" + totalArea);


                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
