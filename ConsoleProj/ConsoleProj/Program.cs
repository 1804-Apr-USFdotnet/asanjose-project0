using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using ClassProj;
using DataLayer;

namespace ConsoleProj
{
    public partial class MainClass
    {
        public static void Main(string[] args)
        {
            Display display = new Display();
            List<Restaurants> list = new List<Restaurants>();
             DisplayUI(list);

            }
      

        }


}