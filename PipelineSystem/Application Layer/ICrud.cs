using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineSystem.Application_Layer
{
    public interface ICrud
    {
        void Add();
        void Retrieve();
        string Update();
        string Delete();
        
    }
}
