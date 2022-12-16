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
                    Name="Books",
                    Image="https://media.istockphoto.com/id/509348476/vector/cute-little-baby-reading-book.jpg?s=612x612&w=0&k=20&c=a3vUKKQBlBzc7HDz3fikel_RAPQ3EIzZIbyS2_7xG28="
                },

            new Category()
            {
                Id=2,
                Name="Car seats",
                Image="https://www.chiccousa.com/on/demandware.static/-/Sites-Chicco-Library/default/dw8c761443/images/baby-talk/keyfit-30.jpg"
            },

            new Category()
            {
                Id=3,
                Name="Bath toys",
                Image="https://metafields-manager-by-hulkapps.s3-accelerate.amazonaws.com/uploads/yookidoo-shop.myshopify.com/1634474533-Bath_Toys_375X375.jpg"
            },

            new Category()
            {
                Id=4,
                Name="Bottle sterilizer",
                Image="https://kdvr.com/wp-content/uploads/sites/11/2022/08/1040x585-2021-0916-best-baby-bottle-sterilizers-065dfd.jpg"
            },

            new Category()
            {
                Id=5,
                Name="Baby cameras",
                Image="https://i.pcmag.com/imagery/reviews/01szgG5mr7x5xqFnO8xvyQo-1..v1629209217.jpg"
            },

            new Category()
            {
                Id=6,
                Name="Sleep bag",
                Image="https://www.silentnight.co.uk/pub/media/catalog/product/b/a/baby-sleep-bag-1.jpg"
            },

            new Category()
            {
                Id=7,
                Name="Bottle feeding",
                Image="https://media.istockphoto.com/id/1306729572/vector/cute-baby-boy-sitting-on-floor-and-reaching-out-to-a-huge-bottle-of-milk.jpg?s=612x612&w=is&k=20&c=KN4ox3aQonjNxZJAeqT9IoPvWyPh6aep1VyfN0sUE0c="
            },

            };

            return categories;
        }
    }
}
