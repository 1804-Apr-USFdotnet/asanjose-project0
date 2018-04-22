using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace ClassProj
    {
    public class Display
        {
            public void DisplayReviews<T>(List<T> stuff) //Could be used similarilly for displaying details as well
            {
            
                foreach (var item in stuff)
                {
                    Console.WriteLine(item + " ");
                }

            }


            public void DisplayRestauratnts(ArrayList[] rest)
            {

                for (int i = 0; i < rest.Length; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        Console.Write(rest[j][i] + " ");

                        if (j == 2)
                        {
                            Console.WriteLine();

                        }

                    }

                }



            }

            public void DisplayTop3<T>(List<T> datainfo)
            {

                var data = (from dat in datainfo
                            orderby dat descending
                            select dat).Take(3);

                foreach (var item in data)
                {

                    Console.Write(item + ", ");
                }
                Console.WriteLine();

            }


            public void DisplayAvg(List<double> rating)
            { //Potentially put all the averages into 1 list?

                var result = rating.Average();
                Console.WriteLine(result);


            }



    }
}
