using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PipelineSystem.Application_Layer
{

    public class PipeLineRepo : ICrud
    {
        public List<Pipeline> pipeLineRepos = new List<Pipeline>();
        // public void movePosition();
        // public void addPipeline

        public void Add()
        {
            
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public void Retrieve()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
        

    }
}
