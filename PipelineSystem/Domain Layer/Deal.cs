using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineSystem
{
    class Deal
    {
        private string dealName;
        public string DealName
        {
            get
            {
                return name1;
            }
            set
            {
                name1 = value;
                Textbox.content = name1;
            }
        }
        
        public string ContactName;
        public int Value;
    }
}
