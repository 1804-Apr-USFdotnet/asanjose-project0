using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ClassProj;
using DataStuff;

namespace ConsoleProj
{
    public partial class MainClass
    {
        public static void Main(string[] args)
        {
            Display display = new Display();
            List<Restaurants> restaurants = new List<Restaurants>();
            DisplayUI(restaurants);
          


        }

    }
}