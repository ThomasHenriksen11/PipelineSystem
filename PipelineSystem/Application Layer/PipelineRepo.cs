using PipelineSystem;
using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PipelineSystem.UI_Layer;

namespace PipelineSystem.Application_Layer
{

    public class PipeLineRepo : ICrud
    {
        public List<Pipeline> pipeLineRepos = new List<Pipeline>();

        public void Add(string pipeline)
        {
            Pipeline Listitem = new Pipeline {PipelineName = pipeline};
            pipeLineRepos.Add(Listitem);
        }

        public void Delete(Pipeline pipeline)
        {
            pipeLineRepos.Remove(pipeline);
        }

        public string Retrieve(string name)
        {
            /*foreach (Pipeline item in pipeLineRepos.Where(p = p.PipelineName == name))
            {
                name = item.PipelineName;
            }
                    */ return name;
                    
        }
        

        public void Update()
        {
            throw new NotImplementedException();
        }
        // public void movePosition();
        // public void addPipeline

    }
}
