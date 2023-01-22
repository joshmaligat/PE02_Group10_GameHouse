using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public String Name { get; set; }
        public String StaffEmail { get; set; }
        public int SaffContact { get; set; }
        public String StaffAddress { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
