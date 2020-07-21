using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineSystem.Application_Layer
{
    public class TitleRepo : ICrud
    {
        public List<string> titleRepos = new List<string>();
        public void Add(string name)
        {
           titleRepos.Add(name);
        }

        public void Remove(string name) 
        {
            titleRepos.Remove(name);
        }
        public string Retrieve(string name)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
