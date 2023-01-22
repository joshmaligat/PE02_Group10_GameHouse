using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Category : BaseDomainModel
    {

        public int CategoryType { get; set; }
        public int CategoryName { get; set; }
        public virtual List<GamingProduct> GamingProducts { get; set; }
    }
}
