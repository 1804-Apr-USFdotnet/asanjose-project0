using NUnit.Framework;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using ClassProj;


namespace TestingProj
{
    [TestFixture()]
    public class TestAscend
    {
        [Test()]
        public void TestAsc()
        {
            Sorting sorting = new Sorting();
            var expected = new List<string>() { "1", "3", "4", "6" };
            var test = new List<string>() { "3", "4", "1", "6" };
            var actual = sorting.SortAscend(test);

            Assert.AreEqual(expected, actual);

        }
    }
}