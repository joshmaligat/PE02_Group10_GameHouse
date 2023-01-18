using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public String PaymentType { get; set; }
        public String PaymentMethod{ get; set; }
        public double PaymentAmount { get; set; }
        public int OrderID { get; set; }
        public virtual Order Orders { get; set; }
    }
}
