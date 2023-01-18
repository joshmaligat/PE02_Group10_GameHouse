using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class ShippingAddress : BaseDomainModel
    {
        public String ShippingAdd { get; set; }
        public String ShippingCountry { get; set; }
        public int ShippingPostalCode { get; set; }
        public String ShippingState { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
