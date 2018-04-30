using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;
using DataStuff;



namespace TestingProj
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void DeSerialize()
        {
            List<Restaurants> expected = new List<Restaurants>()
            {
                //new Restaurant("McDonalds", "123 test ave", "Tampa", 4.0, "American")

            };


            List<Restaurants> actual = JsonConvert.DeserializeObject<List<Restaurants>>("[{'RestName' : 'McDonalds', 'Address': '123 test ave', 'City' = 'Tampa' , 'Rating': 4.0 , 'Cuisine': 'American'}]");
            Assert.AreEqual(expected[0], actual[0]);

            }        
    }
}
