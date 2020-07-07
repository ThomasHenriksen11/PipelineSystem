using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PipelineSystem.Application_Layer
{
    public interface ICrud
    {
        void Add(string pipeline);
        void Retrieve(Pipeline pipeline);
        void Update();
        void Delete(Pipeline pipeline); 
        
    }
}
