using System;
using Xunit;
using Zoo.Classes;

namespace ZooTest
{
    public class UnitTest1
    {
        /// <summary>
        ///  Test Beagle is a hunter
        /// </summary>
        [Fact]
        public void BeagleBarkTest()
        {
            Beagle beagle = new Beagle();
            bool hunter = beagle.IsHunter.Equals("I was bred to hunt");

            Assert.True(hunter);
        }
    }
}
