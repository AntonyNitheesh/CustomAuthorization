using Domain.Abstract.Entity;
using Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AdoNet.Repositories
{
    public class LeadSourceRepository : ILeadSourceRepository
    {
        public void DeleteLeadSource(int id)
        {
            throw new NotImplementedException();
        }

        public ILeadSource GetLeadSourceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ILeadSource> GetLeadSources()
        {
            throw new NotImplementedException();
        }

        public void InsertLeadSource(ILeadSource leadSource)
        {
            throw new NotImplementedException();
        }

        public void UpdateLeadSource(ILeadSource leadSource)
        {
            throw new NotImplementedException();
        }
    }
}
