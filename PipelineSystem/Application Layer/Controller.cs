using PipelineSystem.Application_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipelineSystem.UI_Layer;

namespace PipelineSystem.Application_Layer
{
   public class Controller
    {
        public PipeLineRepo pipeLineRepo = new PipeLineRepo();
        public DealRepo dealRepo = new DealRepo();
        public TitleRepo titleRepo = new TitleRepo();
    }   

}
