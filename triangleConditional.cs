using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Computer Programming: Triangle 2017    
            // David Cox

            // Declaring variables
            int a, b, c;  // Triangle sides
            int longest; //Longest side
            bool rightAngle = false; // Declaring shape is not right angle if does not fit sequence equation
                
            // Welcome message
            Console.WriteLine( ); 
            Console.WriteLine("Welcome!"); 

            // Inputs
            Console.WriteLine("To make a triangle you need to measure three sides"); // Instructions
            Console.WriteLine( );

            // Requesting numerical sides
            Console.WriteLine("Input First Side (Please enter a number)"); // Message - First side input request
            a = Convert.ToInt16(Console.ReadLine()); // User inputs a number
            Console.WriteLine( ); 

            Console.WriteLine("Input Second Side (Please enter a number)"); // Message - Second side input request
            b = Convert.ToInt16(Console.ReadLine()); // User inputs a number
            Console.WriteLine( );

            Console.WriteLine("Input Third Side (Please enter a number)"); // Message - Third side input request
            c = Convert.ToInt16(Console.ReadLine()); // User inputs a number
            Console.WriteLine( );

            // Triangle Section
            if (a + b > c && b + c > a && c + a > b) // Triangle calculation
            {
                Console.WriteLine("Congratuations! You have made a triangle"); // Message - notifies user if a triangle is made
            }
            else // If numbers do not calculate to make a triangle
            {
                Console.WriteLine("Unfortunately, these sides do not make a triangle"); // Message - notifies user if a triangle is NOT made
            }
            
            //Equalatral Triangle Section
            if (a == b && b == c && c == a) // Equation asking if all sides are equal
            {
                Console.WriteLine("Equalateral triangle? Yes"); // Message - Confirming an equalateral triangle has been made
            }
            else // If does not fit equation specifics
                Console.WriteLine("Equalateral triangle? No"); // Message - Confirms sides do NOT make an equalateral triangle

            // Right Angle Triangle Section
            if (a > b && a > c) // Calculation to see if 'a' is the longest side
            {
                longest = a; // identifies 'a' as the longest side
                if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                rightAngle = true; 
            }
            else if (b > a && b > c) // Calculation to see if 'b' is the longest side
            {
                longest = b; // identifies 'b' as the longest side
                if (Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2)) 
                rightAngle = true; 
            }
            else if (c > a && c > b) //Calculation to see if 'c' is the longest side
            {
                longest = c; // Identifies 'c' as the longest side
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) 
                rightAngle = true; 
            }
            if (rightAngle) // If a right angle has been made
            {
                Console.WriteLine("Right angle triangle? Yes"); // Message - Notifies user shape is a right angle triangle
            }
            else
                Console.WriteLine("Right angle triangle? No"); // Message - Notifies user shape is NOT a right angle triangle
            
            // Isosceles Triangle Section
            if (a == b && a + b > c && b + c > a && c + a > b) // Check if sides 'a' and 'b' are equal and that still forms a triangle
            {
                Console.WriteLine("Isosceles triangle? Yes"); 
            }

            else if (b == c && a + b > c && b + c > a && c + a > b) // Check if sides 'b' and 'c' are equal and that still forms a triangle
            {
                Console.WriteLine("Isosceles triangle? Yes");
            }
            else if (c == a && a + b > c && b + c > a && c + a > b) // Check if sides 'c' and 'a' are equal and that still forms a triangle
            {
                Console.WriteLine("Isosceles triangle? Yes"); 
            }
            else
            Console.WriteLine("Isosceles triangle? No"); // Message - confirmation triangle is not an isosceles triangle

            // Scalene Triangle Section
            if (a > b && b < c && c > a && a + b > c && b + c > a && c + a > b) // These equations check if all sides are unequal
            {
                Console.WriteLine("Scalene triangle? Yes"); // Message - Confirms shape is scalene
            }
            else if (b > c && c < a && a > b && a + b > c && b + c > a && c + a > b) // Check sides are unequal 1
            {
                Console.WriteLine("Scalene triangle? Yes"); 
            }
            else if (c > a && a < b && b > c && a + b > c && b + c > a && c + a > b) // Check sides are unequal 2
            {
                Console.WriteLine("Scalene triangle? Yes"); 
            }
            else if (a < b && b > c && c < a && a + b > c && b + c > a && c + a > b) // Check sides are unequal 3
            {
                Console.WriteLine("Scalene triangle? Yes"); 
            }
            else if (b < c && c > a && a < b && a + b > c && b + c > a && c + a > b) // Check sides are unequal 4
            {
                Console.WriteLine("Scalene triangle? Yes"); 
            }
            else if (c < a && a > b && b < c && a + b > c && b + c > a && c + a > b) // Check sides are unequal 5
            {
                Console.WriteLine("Scalene triangle? Yes"); 
            }
            else // This confirms triangle has at least two sides the same
                Console.WriteLine("Scalene triangle? No"); // Message - Confirms shape is NOT scalene

            Console.WriteLine( );
            Console.WriteLine("Please press any key to continue."); // Message instructing user how to exit program
            Console.ReadLine(); // Stops program from closing without warning

        } // End String
    } // End Class
} // End Namespace
