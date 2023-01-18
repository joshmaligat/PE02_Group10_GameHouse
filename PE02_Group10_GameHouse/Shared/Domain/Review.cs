using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public String ReviewMessage { get; set; }
        public int ReviewRating { get; set; }
        public int ProductID { get; set; }
        public virtual GamingProduct Products { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
