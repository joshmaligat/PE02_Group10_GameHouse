using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE02_Group10_GameHouse.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
    }
}
