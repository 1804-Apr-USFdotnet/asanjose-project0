using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataStuff
{
    [Table("Review")]
    public class Reviews
    {
        
        public int RestID { get; set; }
        public string Restaurant { get; set; }
        public decimal Rating { get; set; }
        public string Review { get; set; }
        [Key]
        public string UserID { get; set; }



        public Reviews()
        {



        }

        public Reviews(int ID, string name, decimal rating, string review,string user)
        {

            RestID = ID;
            Restaurant = name;
            Rating = rating;
            Review = review;
            UserID = user;


        }

        public override string ToString()
        {
            return $"\nRestID:{RestID} \nRestaurant: {Restaurant} \nRating: {Rating} \nReview: {Review} \nUserID: {UserID} ";

        }



    }
}
