using System;

namespace _18._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give side of Squre :");
            double side = Convert.ToDouble(Console.ReadLine());
            Square squre = new Square(side);

            Console.Write("Please give length of the Rectangular : ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please give width of the Rectangular : ");
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangular rectangular = new Rectangular(length, width);



            int choice;

            do
            {
                Console.WriteLine("Enter number :  1)Area of the squre   2)Area of the rectangular   0)Quite");
                
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(squre.CalcArea()+"m^2");
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        
                        break;
                    case 2:
                        double a = rectangular.Length;
                        double b = rectangular.Width;
                        if (a!=b)
                        {
                            Console.WriteLine(rectangular.CalcArea()+"m^2");
                            Console.WriteLine("-----------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("It's not rectangular ,it's a squre");
                            Console.WriteLine(squre.CalcArea()+"m^2"); 
                        }
                        break;
                    case 0:
                        Console.WriteLine("Program ended");
                        break;
                    default:
                        Console.WriteLine("You have to press 1,2 and 3 ");
                        break;
                }
            } while (choice != 0);
            
        }
    }
}

