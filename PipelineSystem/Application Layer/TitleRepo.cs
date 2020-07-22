using System;
using System.Collections.Generic;

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
