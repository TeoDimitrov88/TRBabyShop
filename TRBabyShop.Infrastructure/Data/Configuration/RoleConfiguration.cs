
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Configuration
{
    public class RoleConfiguration: IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            var roles = new List<IdentityRole>();

            var admin = new IdentityRole()
            {
                Id = "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
               Name="admin",
               NormalizedName = "ADMIN",

            };


            var customer = new IdentityRole()
            {
                Id = "e46a2abc-d6e9-4333-a560-989dc89f5797",
                Name = "customer",
                NormalizedName = "CUSTOMER"
            };

            return roles;
        }
    }
}
