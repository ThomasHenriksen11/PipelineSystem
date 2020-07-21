using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipelineSystem.Application_Layer;
using PipelineSystem.Domain_Layer;
using PipelineSystem.UI_Layer;
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
            string piplename1 = "Velepo";
            PipeLineRepo pipeLineRepoTest = new PipeLineRepo;
            // act 
            pipeLineRepoTest.Add(piplename1);
            // assert
            
        }
    }
}
