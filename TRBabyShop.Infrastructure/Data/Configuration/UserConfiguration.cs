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

            var hasher = new PasswordHasher<AppUser>();

            var user = new AppUser()
            {
                Id = "04ba4719-a5ce-478d-b36d-169ffe19e118",
                UserName = "teodor88",
                NormalizedUserName = "TEODOR88",
                Email = "teo88@abv.bg",
                NormalizedEmail = "TEO88@ABV.BG",
                PasswordHash = hasher.HashPassword(null, "Teo12!")

            };

            users.Add(user);

            var user2 = new AppUser()
            {
                Id = "d381c77f-aabf-46bd-80e3-cf9ee84a668b",
                UserName = "ivan89",
                NormalizedUserName = "IVAN89",
                Email = "ivan89@abv.bg",
                NormalizedEmail = "IVAN89@ABV.BG",
                PasswordHash = hasher.HashPassword(null, "Teo12!")
            };

            users.Add(user2);

            var user3 = new AppUser()
            {
                Id = "cd0f2b40-9353-405c-ae22-c1097419f287",
                UserName = "hristo80",
                NormalizedUserName = "HRISTO80",
                Email = "hristo80@abv.bg",
                NormalizedEmail = "HRISTO80@ABV.BG",
                PasswordHash = hasher.HashPassword(null, "Teo12!")
            };

            users.Add(user3);

            var user4 = new AppUser()
            {
                Id = "c225f1de-8898-473c-8b8d-484a5034beea",
                UserName = "tina93",
                NormalizedUserName = "TINA93",
                Email = "tina93@abv.bg",
                NormalizedEmail = "TINA93@ABV.BG",
                PasswordHash = hasher.HashPassword(null, "Teo12!")
            };

            users.Add(user4);

            var user5 = new AppUser()
            {
                Id = "1163da51-2369-4b12-aef5-86c360e358de",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                PasswordHash = hasher.HashPassword(null, "Admin12!")
            };

            users.Add(user5);

            return users;
        }
    }
}
