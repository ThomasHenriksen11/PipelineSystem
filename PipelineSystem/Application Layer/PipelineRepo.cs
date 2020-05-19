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
        public List<PipeLineRepo> pipeLineRepos = new List<PipeLineRepo>();
        // public void movePosition();
        // public void addPipeline
        
        public void AddNewPipeline(PipeLineRepo pipeLineRepo)
        {
            pipeLineRepos.Add(pipeLineRepo);
        }
    }
}
