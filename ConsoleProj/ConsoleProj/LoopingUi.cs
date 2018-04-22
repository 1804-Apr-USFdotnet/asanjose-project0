using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ClassProj;


namespace ConsoleProj
{
    public partial class MainClass
    {
        public static void DisplayUI<T>(List<T> stuff)
        {
            Display display = new Display();
            Console.WriteLine("Press 1: Display All Restaurants");
            Console.WriteLine("Press 2: Display Top 3 Resturants");
            Console.WriteLine("Press 3: Display Restaurant Details");
            Console.WriteLine("Press 4: Search for Restaurant");
            Console.WriteLine("Press 5: Display Reviews for Restaurant");
            Console.WriteLine("Press 0: Exit Application");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input != 0)
            {
                if (input > 5)
                {
                    Console.WriteLine("Invalid Input! Try again.");
                    DisplayUI(stuff);
                }

                else if (input == 2)
                {
                    display.DisplayTop3(stuff);
                    Console.WriteLine();

                }

                else if (input == 5)
                {
                    display.DisplayReviews(stuff);
                    Console.WriteLine();
                }

                Console.WriteLine("Press 1: Display All Restaurants");
                Console.WriteLine("Press 2: Display Top 3 Resturants");
                Console.WriteLine("Press 3: Display Restaurant Details");
                Console.WriteLine("Press 4: Search for Restaurant");
                Console.WriteLine("Press 5: Display Reviews for Restaurant");
                Console.WriteLine("Press 0: Exit Application");

                input = Convert.ToInt32(Console.ReadLine());
            }

        }
    }

    }




