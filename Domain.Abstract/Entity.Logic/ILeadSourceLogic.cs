using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract.Entity.Logic
{
    public interface ILeadSourceLogic
    {
        List<ILeadSource> GetLeadSources();

        ILeadSource GetLeadSourceById(int id);
        void InsertLeadSource(ILeadSource leadSource);
        public void UpdateLeadSource(ILeadSource leadSource);

        void DeteteLeadSource(int id);
    }
}
