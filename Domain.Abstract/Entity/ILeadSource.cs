using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract.Entity
{
    public interface ILeadSource
    {
        public int SourceId { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
    }
}
