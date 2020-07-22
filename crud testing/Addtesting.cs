using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipelineSystem.Application_Layer;
using PipelineSystem.Domain_Layer;
using System.Collections.Generic;

namespace crud_testing
{
    [TestClass]
    public class Addtesting
    {



        [TestMethod]
        public void TestMethod1()
        {
            // arrange 
            string sa = "sa";
            string name = "qwerty";
            string value = "42";
            DealRepo repo = new DealRepo();
            List<Deal> deals = new List<Deal>();
            Deal Cat = new Deal();
            Cat.ContactName = "sa";
            Cat.Name = "qwerty";
            Cat.Value = "42";
            // act
            deals.Add(Cat);
            List<Deal> actual = repo.Add(sa, name, value);
            // assert
            Assert.AreEqual(deals, actual);
        }
    }
}
