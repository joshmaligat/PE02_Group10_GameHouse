using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public int Contact { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
