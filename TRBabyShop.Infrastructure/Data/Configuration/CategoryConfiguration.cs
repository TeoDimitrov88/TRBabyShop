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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id=1,
                    Name="Books"
                },

            new Category()
            {
                Id=2,
                Name="Car seats"
            },

            new Category()
            {
                Id=3,
                Name="Bath toys"
            },

            new Category()
            {
                Id=4,
                Name="Car Seats"
            },

            new Category()
            {
                Id=5,
                Name="Baby cameras"
            },

            new Category()
            {
                Id=6,
                Name="Sleep bag"
            },

            new Category()
            {
                Id=7,
                Name="Bottle feeding"
            },

            };

            return categories;
        }
    }
}
