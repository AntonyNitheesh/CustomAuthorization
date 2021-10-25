using Domain.Abstract.Entity;
using Domain.Abstract.Entity.Logic;
using Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Logic
{
    public class LeadSourceLogic : ILeadSourceLogic
    {
        ILeadSourceRepository _leadSourceRepository;

        public LeadSourceLogic(ILeadSourceRepository leadSourceRepository)
        {
            _leadSourceRepository = leadSourceRepository;
        }

        public void DeteteLeadSource(int id)
        {
            _leadSourceRepository.DeleteLeadSource(id);
        }

        public ILeadSource GetLeadSourceById(int id)
        {
            return _leadSourceRepository.GetLeadSourceById(id);
        }

        public List<ILeadSource> GetLeadSources()
        {
            var sources = _leadSourceRepository.GetLeadSources();
            return sources;
        }

        public void InsertLeadSource(ILeadSource leadSource)
        {
            _leadSourceRepository.InsertLeadSource(leadSource);
        }

        public void UpdateLeadSource(ILeadSource leadSource)
        {
            _leadSourceRepository.UpdateLeadSource(leadSource);
        }
    }
}
