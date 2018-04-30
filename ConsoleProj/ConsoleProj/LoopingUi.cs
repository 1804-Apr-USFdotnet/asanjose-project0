using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NLog;
using ClassProj;


namespace ConsoleProj
{
    public partial class MainClass
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void DisplayUI<T>(List<T> stuff)
        {   
            
            Sorting sort = new Sorting();
            Display display = new Display();
            PartialSearch partial = new PartialSearch();
            int input; 
          
            Console.WriteLine("Press 1: Display All Restaurants");
            Console.WriteLine("Press 2: Display Top 3 Resturants");
            Console.WriteLine("Press 3: Display Restaurant Details");
            Console.WriteLine("Press 4: Search for Restaurant");
            Console.WriteLine("Press 5: Display Reviews for Restaurant");
            Console.WriteLine("Press 6: Sort Restaurants in Ascending Order");
            Console.WriteLine("Press 7: Sort Restaurants in Descending Order");
            Console.WriteLine("Press 8: Sort Restaurants by Most Reviews");
            Console.WriteLine("Press 9: Average Restaurant Ratings");
            Console.WriteLine("Press 0: Exit Application");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());

            
                while (input != 0)
                {
                    if (input > 9)
                    {
                        Console.WriteLine("Invalid Input! Try again.");
                    }

                  else if (input == 1)
                    {
                        display.RestNames(stuff);
                        Console.WriteLine();

                    }


                    else if (input == 2)
                    {
                        display.DisplayTop3(stuff);
                        Console.WriteLine();

                    }

                    else if (input == 3)
                    {
                        display.DisplayRestaurants(stuff);
                        Console.WriteLine();
                    }


                    else if (input == 4){
                        partial.SearchFunc(stuff);
                        Console.WriteLine();

                    }

                    else if (input == 5)
                    {
                        display.DisplayReviews(stuff);
                        Console.WriteLine();
                    }

                    else if (input == 6){
                        sort.SortAscend(stuff);
                        Console.WriteLine();

                    }

                    else if (input == 7)
                    {
                        sort.SortDescend(stuff);
                        Console.WriteLine();

                    }

                    else if (input ==8)
                    {
                        sort.SortCuisine(stuff);
                        Console.WriteLine();
                    }

                    else if (input == 9)
                        {
                        display.DisplayAvg(stuff);
                        Console.WriteLine();
                    }

                    Console.WriteLine("Press 1: Display All Restaurants");
                    Console.WriteLine("Press 2: Display Top 3 Resturants");
                    Console.WriteLine("Press 3: Display Restaurant Details");
                    Console.WriteLine("Press 4: Search for Restaurant");
                    Console.WriteLine("Press 5: Display Reviews for Restaurant");
                    Console.WriteLine("Press 6: Sort restaurants in ascending order");
                    Console.WriteLine("Press 7: Sort restaurants in descending order");
                    Console.WriteLine("Press 8: Sort restaurants by cuisine");
                    Console.WriteLine("Press 9: Average Restaurant Ratings");
                    Console.WriteLine("Press 0: Exit Application");

                   input = Convert.ToInt32(Console.ReadLine());
                }

            
            }

            catch (FormatException )
            {
                logger.Error("Wrong data type. Please type the desired number!");
                DisplayUI(stuff);
            }

            catch (OverflowException){

                logger.Error("Intger you inputted was too large");
                DisplayUI(stuff);
            }

            catch(Exception){

                logger.Error("Error.....");
                DisplayUI(stuff);

            }



      
        }
    }

    }




