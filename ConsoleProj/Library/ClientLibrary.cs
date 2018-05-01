using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ClientLibrary
    {
        RestaurantCrud crud = new RestaurantCrud();

        public void PrintReview()
        {
            Console.WriteLine(crud.GetRestaurant(1));
        }

    }
}
