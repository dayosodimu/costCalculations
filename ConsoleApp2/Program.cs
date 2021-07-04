using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // User to enter floor width
                Console.WriteLine("Enter floor width in inches");
                int inchWidth = Convert.ToInt32(Console.ReadLine());

                // User to enter floor lenght
                Console.WriteLine("Enter floor lenght in inches");
                int inchLenght = Convert.ToInt32(Console.ReadLine());

                // Converting inches to feet
                decimal totalWidthinFeet = (inchWidth / 12);
                decimal totalLengthinFeet = (inchLenght / 12);

                var totalArea = totalLengthinFeet * totalWidthinFeet;
                Console.WriteLine("The total area cost is " + totalArea);


                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
