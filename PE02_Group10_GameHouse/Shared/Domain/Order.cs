using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Order : BaseDomainModel
    {

        public DateTime OrderDateTime { get; set; }
        public DateTime OrderArrivalTime { get; set; }
        public DateTime OrderArrivalDate { get; set; }
        public int OrderTotalPrice { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staffs { get; set; }
        public int ShippingAddID { get; set; }
        public virtual ShippingAddress ShippingAddresses { get; set; }
        public virtual List<OrderItem> OrdersItems { get; set; }
    }
}
