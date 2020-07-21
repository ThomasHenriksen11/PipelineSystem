using PipelineSystem.Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineSystem.Application_Layer
{
    public class DealRepo : ICrud
    {
        public List<Deal> dealRepos = new List<Deal>();
        public void Add(string name)
        {
            Deal Listitem = new Deal { Name = name };
            dealRepos.Add(Listitem);
        }
        public void Add(string name, string contactName,string value)
        {
            Deal Listitem = new Deal { Name = name, ContactName = contactName, Value = value};
            dealRepos.Add(Listitem);
        }
        public void Delete(Deal deal)
        {
            dealRepos.Remove(deal);
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
