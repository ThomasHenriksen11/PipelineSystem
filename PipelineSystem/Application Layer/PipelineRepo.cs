using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PipelineSystem.Application_Layer_V2
{

    public class PipeLineRepo
    {
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
