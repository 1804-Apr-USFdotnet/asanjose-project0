using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace DataStuff
{
    public class RestaurantCrud
    {
       Model1 db = new Model1();
        

        public IEnumerable<Restaurants> GetRestaurants()
        {
            return db.restaurants.ToList();
        }
            
        public Restaurants GetRestaurant(int id)
        {
            return db.restaurants.Find(id);
        }

    }
}
