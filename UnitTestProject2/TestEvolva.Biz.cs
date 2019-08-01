using System;
using Evolva.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMissionEvolva
{
    [TestClass]
    public class TestEvolva
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            var CurrentActor = new Actor();
            var expected = "Actor";

            string result = CurrentActor.GetOccupation();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            var CurrActorName = new Actor("Johnny");
            var expected = "Johnny";

            string result = CurrActorName.ActorName;
            Assert.AreEqual(expected, result);
        }
    }
}
