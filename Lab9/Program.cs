using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {

            int option;
            int sum = 0;
            
            Circle test;
            
            do
            {

                Console.WriteLine("Welcome to the circle program.  Please choose an option below:");

                string[] options = {
                                     "Calculate Formatted Area (2 decimal places)",
                                     "Calculate Formatted Circumference (2 decimal places)",
                                     "Calculate Unformatted Area" ,
                                     "Calculate Unformatted Circumference" };

                genList(options, out option);
                
                switch (option)
                {
                    
                    case 1:
                        test = createCircle();
                        Console.WriteLine(test.getFormattedArea());
                        sum++;
                        break;
                    case 2:
                        test = createCircle();
                        Console.WriteLine(test.getFormattedCircumference());
                        sum++;
                        break;
                    case 3:
                        test = createCircle();
                        Console.WriteLine(test.getArea());
                        sum++;
                        break;
                    case 4:
                        test = createCircle();
                        Console.WriteLine(test.getCircumference());
                        sum++;
                        break;

                    default:
                        break;
                }

            } while (keepGoing());

            Console.WriteLine("Goodbye. You created {0} circle objects", sum);



        }



        static void genList(string[] names, out int option)
        {
            Boolean valid = false;
            int input = 0;

            while (valid == false)
            {

                Console.WriteLine("Please choose one of the following options: ");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(i + 1 + ": " + names[i]);
                }

              
                

                if (!(int.TryParse(Console.ReadLine(), out input)))
                {
                    Console.WriteLine("You entered an invalid number");
                    
                }
                
                

                if ((input > 0) && (input <= names.Length+1))
                {
                    Console.WriteLine("\nYou chose " + names[input - 1] + "\n");
                    valid = true;
                }
                else
                {
                    valid = false;
                }


            }
            option = input;

        }


        static bool keepGoing()
        {
            /* Name: keepGoing
            * Description:  This method implements a loop to determine if users wants to continue
            * Input:  None
            * Output: Returns false if user doesn't want to continue.  Otherwise returns true.
            *         Outputs values to Console
            */


            // If user enters "q", execute exit procedure
            Console.WriteLine("\nContinue? (y/n):");
            string input = Console.ReadLine();

            if (input == "n")
            {
               
                return false;
                
            }

            return true;
        }


        private static Circle createCircle()
        {
            double radius = 0;
            bool goodCircle = false;
            
            while (goodCircle == false)
            {
                Console.Write("Please enter the radius of the circle you want to create: ");
                if (!(double.TryParse(Console.ReadLine(), out radius))  || (radius <= 0))
                 {
                    Console.WriteLine("You entered an invalid radius.  Radius must be a number greater than 0");
                    goodCircle = false;
                }
                else
                {
                    goodCircle = true;
                }
           
            }
        
               Circle circle1 = new Circle(radius);
               return circle1;
            
        }


    }

}


