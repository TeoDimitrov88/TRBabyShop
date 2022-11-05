using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Models
{
    public class AppUser:IdentityUser
    {
        public List<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
    }
}
