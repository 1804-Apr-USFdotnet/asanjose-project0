using System;
using System.Collections.Generic;
using System.Linq;
using DataStuff;

namespace ClassProj
{
    public class Sorting
    {
        public int i = 0;
        public List<T> SortAscend<T>(List<T> content)
        {

            using (var db = new Model1())
            {
                var data = (from name in db.restaurants
                            orderby name.Restaurant ascending
                            select name);

                foreach (var item in data)
                {
                    Console.WriteLine(item);


                }

                return content;
            }
        }


        public List<T> SortDescend<T>(List<T> content)
        {
           

            using (var db = new Model1())
            {
                var data = (from name in db.restaurants
                            orderby name.Restaurant descending
                            select name);

                foreach (var item in data)
                {
                    Console.WriteLine(item);


                }

                return content;
            }
        }




        public void SortCuisine<T>(List<T> type)
        {
            var desired = Console.ReadLine();

            using (var db = new Model1())
            {
                var data = (from name in db.restaurants
                            orderby name.Cuisine.Contains(desired) ascending
                            select name);

                foreach (var item in data)
                {
                    Console.WriteLine(item);


                }

            }


        }
    }
}
