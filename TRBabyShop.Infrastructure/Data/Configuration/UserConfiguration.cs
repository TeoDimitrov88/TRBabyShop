using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<AppUser> CreateUsers()
        {
            var users = new List<AppUser>();

            var hasher=new PasswordHasher<AppUser>();

            var user = new AppUser()
            {
                Id = "04ba4719-a5ce-478d-b36d-169ffe19e118",
                UserName = "teodor88",
                NormalizedUserName = "teodor88",
                Email = "teo88@abv.bg",
                NormalizedEmail = "teo88@abv.bg"
                
            };
            user.PasswordHash = hasher.HashPassword(user, "teo12!");

            users.Add(user);

            var user2 = new AppUser()
            {
                Id = "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                UserName = "ivan89",
                NormalizedUserName = "ivan89",
                Email = "ivan89@abv.bg",
                NormalizedEmail = "ivan89@abv.bg"
            };
            user.PasswordHash = hasher.HashPassword(user2, "teo12!");

            users.Add(user2);

            var user3 = new AppUser()
            {
                Id = "cd0f2b40-9353-405c-ae22-c1097419f287",
                UserName = "hristo80",
                NormalizedUserName = "hristo80",
                Email = "hristo80@abv.bg",
                NormalizedEmail = "hristo80@abv.bg"
            };
            user.PasswordHash = hasher.HashPassword(user3, "teo12!");

            users.Add(user3);

            var user4 = new AppUser()
            {
                Id = "c225f1de-8898-473c-8b8d-484a5034beea",
                UserName = "tina93",
                NormalizedUserName = "tina93",
                Email = "tina93@abv.bg",
                NormalizedEmail = "tina93@abv.bg"
            };
            user.PasswordHash = hasher.HashPassword(user4, "teo12!");

            users.Add(user4);

            var user5 = new AppUser()
            {
                Id = "1163da51-2369-4b12-aef5-86c360e358de",
                UserName = "admin12",
                NormalizedUserName = "ADMIN12",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@abv.bg"
            };
            user.PasswordHash = hasher.HashPassword(user4, "Admin123!");

            users.Add(user5);

            return users;
        }
    }
}
