using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 

namespace PipelineSystem.Application_Layer
{

    public class PipeLineRepo : IPipelineManagement
    {
        public void createPipeline()
        {
            throw new NotImplementedException();
        }

        public void DeletePipeline()
        {
            throw new NotImplementedException();
        }

        public void RetrievePipeline()
        {
            throw new NotImplementedException();
        }

        public void UpdatePipeline()
        {
            throw new NotImplementedException();
        }
    }

    public List<Pipeline> pipeLineRepos = new List<Pipeline>();
        // public void movePosition();
        // public void addPipeline
        
        public void AddNewPipeline(Pipeline pipeline)
        {
            pipeLineRepos.Add(pipeline);
        }

        public List<Pipeline> GetAll()
        {
            return pipeLineRepos;
        }

    }
}
