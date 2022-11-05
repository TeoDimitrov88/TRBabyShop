//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TRBabyShop.Infrastructure.Data.Models;

//namespace TRBabyShop.Infrastructure.Data.Configuration
//{
//    public class ProductConfiguration : IEntityTypeConfiguration<Product>
//    {
//        public void Configure(EntityTypeBuilder<Product> builder)
//        {
            
//        }

//        private List<Product> CreateProducts()
//        {
//            List<Product> products = new List<Product>()
//            {
//                new Product()
//                {
//                    Id=1,
//                    Name="Books",
//                    Description="",
//                    Price= ,
//                    Image="",
//                    CategoryId=1,
//                    Reviews= new List<Review>()
//                    {

//                    }

//                },

//            new Category()
//            {
//                Id=2,
//                Name="Car seats"
//            },

//            new Category()
//            {
//                Id=3,
//                Name="Bath toys"
//            },

//            new Category()
//            {
//                Id=4,
//                Name="Car Seats"
//            },

//            new Category()
//            {
//                Id=5,
//                Name="Baby cameras"
//            },

//            new Category()
//            {
//                Id=6,
//                Name="Sleep bag"
//            },

//            new Category()
//            {
//                Id=7,
//                Name="Bottle feeding"
//            },

//            };

//            return categories;
//        }
//    }
//}
