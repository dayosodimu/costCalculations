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
                double inchWidth = Convert.ToDouble(Console.ReadLine());

                // User to enter floor lenght
                Console.WriteLine("Enter floor lenght in inches");
                double inchLenght = Convert.ToDouble(Console.ReadLine());

                // Converting inches to feet
                double totalWidthinFeet = (inchWidth / 12);
                double totalLengthinFeet = (inchLenght / 12);

                double totalAreaSquareFeet = totalLengthinFeet * totalWidthinFeet;

                // Cost Per unit
                double costPerUnit = 6.99;
                
                double totalAmount = totalAreaSquareFeet * costPerUnit;
                Console.WriteLine("Cost per unt: " + totalAmount);

                // Cost per Area of flooring
                Console.WriteLine("This program calcuates the area of flooring");



                //TODO: Calculate cost of labour per hour


                //TODO: Output total cost
                Console.WriteLine("The cost per area of flooring is" + totalAmount * totalAreaSquareFeet);

                Console.WriteLine();

                Console.ReadKey();
             
             }
        }
    }
}