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

                var totalAreaSquareFeet = totalLengthinFeet * totalWidthinFeet;
                Console.WriteLine("The total area is " + totalAreaSquareFeet);

                //TODO: Calcuclate total cost

                //TODO: Output total cost




                Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
