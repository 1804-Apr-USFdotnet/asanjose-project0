using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DataStuff
{
    [Table("Restaurant")]
    public class Restaurants
    {
        [Key]
        public int RestID { get; set; }
        public string Restaurant { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public decimal Rating { get; set; }
        public string Cuisine { get; set; }

        public Restaurants()
        {
        }

        public Restaurants(int restid, string rest, string address, string city, decimal rate, string cuisine)
        {
            RestID = restid;
            Restaurant = rest;
            Address = address;
            City = city;
            Rating = rate;
            Cuisine = cuisine;

        }

        public override string ToString()
        {
            return $"\nRestID:{RestID} \nRname: {Restaurant} \nAddress: {Address} \nCity: {City} \nRating: {Rating} \nCuisine: {Cuisine} ";

          }
    } 
}