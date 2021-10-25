using Domain.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract.Repositories
{
    public interface ILeadSourceRepository
    {
        List<ILeadSource> GetLeadSources();
        ILeadSource GetLeadSourceById(int id);
        void InsertLeadSource(ILeadSource leadSource);
        void UpdateLeadSource(ILeadSource leadSource);
        void DeleteLeadSource(int id);
    }
}
