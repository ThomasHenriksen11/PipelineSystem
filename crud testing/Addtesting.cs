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

            PipeLineRepo pipeLineRepo = new PipeLineRepo();
            List<Pipeline> pipelineRepos = new List<Pipeline>();
            string Name1 = "Sales";
            string Name2 = "Hansen advokat"; 
            string Name3 = "Oles olie";
            Pipeline pipeline1 = new Pipeline { PipelineName = Name1};
            Pipeline pipeline2 = new Pipeline { PipelineName = Name2};
            Pipeline pipeline3 = new Pipeline { PipelineName = Name3};
            // act
            pipelineRepos.Add(pipeline1);
            pipelineRepos.Add(pipeline2);
            pipelineRepos.Add(pipeline3);
            // assert
            List<Pipeline> testList = new List<Pipeline>();
            testList.Add(pipeline1);
            testList.Add(pipeline2);
            testList.Add(pipeline3);

            Assert.AreEqual(testList, pipelineRepos);

            /*var expected = new List<string>();
            expected.AddRange(new [] {Name1, Name2, Name3});
            var actual = new List<Pipeline>();
            actual.AddRange(new [] {pipeline1, pipeline2, pipeline3});
            CollectionAssert.AreEquivalent(expected, actual);*/
        }
    }               
}
