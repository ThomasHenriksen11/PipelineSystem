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
        void Add(string name);
        string Retrieve(string name);
        void Update();
        void Delete(Pipeline pipeline); 
        
    }
}
