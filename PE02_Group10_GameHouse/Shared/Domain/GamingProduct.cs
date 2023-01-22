using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class GamingProduct : BaseDomainModel
    {
        public String Name { get; set; }
        public String ProductDesc { get; set; }
        public int ProductCost { get; set; }
        public int ProductStock { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Categorys { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
