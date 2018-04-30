using NUnit.Framework;
using System;
using System.Collections.Generic;
using ClassProj;


namespace TestingProj
{
    [TestFixture()]
    public class TestDescend
    {
        [Test()]
        public void TestDesc()
        {
            Sorting sorting = new Sorting();
            var expected = new List<string>() { "6", "4" , "3", "1" };
            var test = new List<string>() { "3", "4", "1", "6" };
            var actual = sorting.SortDescend(test);

            Assert.AreEqual(expected, actual);

        }
    }
}