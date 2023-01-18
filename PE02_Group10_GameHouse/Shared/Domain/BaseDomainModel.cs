using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int ID { get; set; }
        public String CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public String UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
