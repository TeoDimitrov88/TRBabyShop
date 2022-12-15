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
    public class UserRolesConfiguration: IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUserRoles());
        }

        private List<IdentityUserRole<string>> CreateUserRoles()
        {
            var users = new List<IdentityUserRole<string>>();

            var admin = new IdentityUserRole<string>()
            {
                RoleId= "NU89ca4e53-4fbf-46de-93e3-ee20568d4833LL",
                UserId= "1163da51-2369-4b12-aef5-86c360e358de"
            };
            users.Add(admin);

            var user = new IdentityUserRole<string>()
            {
                RoleId = "e46a2abc-d6e9-4333-a560-989dc89f5797",
                UserId = "04ba4719-a5ce-478d-b36d-169ffe19e118"
            };
            users.Add(user);

            var user2 = new IdentityUserRole<string>()
            {
                RoleId = "e46a2abc-d6e9-4333-a560-989dc89f5797",
                UserId = "d381c77f-aabf-46bd-80e3-cf9ee84a668b"
            };
            users.Add(user2);

            var user3 = new IdentityUserRole<string>()
            {
                RoleId = "e46a2abc-d6e9-4333-a560-989dc89f5797",
                UserId = "cd0f2b40-9353-405c-ae22-c1097419f287"
            };
            users.Add(user3);

            var user4 = new IdentityUserRole<string>()
            {
                RoleId = "e46a2abc-d6e9-4333-a560-989dc89f5797",
                UserId = "c225f1de-8898-473c-8b8d-484a5034beea"
            };
            users.Add(user4);

            return users;

        }
    }
}
