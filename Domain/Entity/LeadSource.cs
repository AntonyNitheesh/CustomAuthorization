using Domain.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class LeadSource : ILeadSource
    {
        public int SourceId { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
    }
}
