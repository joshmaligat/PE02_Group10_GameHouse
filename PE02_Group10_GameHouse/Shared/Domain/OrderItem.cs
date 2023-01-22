using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderQty { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public virtual GamingProduct Products { get; set; }

    }
}
