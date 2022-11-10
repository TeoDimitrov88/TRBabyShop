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
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(CreateReviews());
        }

        private List<Review> CreateReviews()
        {
            List<Review> reviews = new List<Review>()
            {
                new Review()
                {
                    Id = 1,
                    UserId="04ba4719-a5ce-478d-b36d-169ffe19e118",
                    Text="Amazing item!",
                    ProductId=1,
                    CreatedOn=DateTime.Now,
                },
                 new Review()
                {
                    Id = 2,
                    UserId="04ba4719-a5ce-478d-b36d-169ffe19e118",
                    Text="Very usefull!!Thank you",
                    ProductId=3,
                    CreatedOn=DateTime.Now,
                },
                  new Review()
                {
                    Id = 3,
                    UserId="c225f1de-8898-473c-8b8d-484a5034beea",
                    Text="It`s perfect for our baby!Thank you",
                    ProductId=3,
                    CreatedOn=DateTime.Now,
                },
                  new Review()
                {
                    Id = 4,
                    UserId="04ba4719-a5ce-478d-b36d-169ffe19e118",
                    Text="Low quality ,im very upset :(",
                    ProductId=8,
                    CreatedOn=DateTime.Now,
                },
                    new Review()
                {
                    Id = 5,
                    UserId="04ba4719-a5ce-478d-b36d-169ffe19e118",
                    Text="Excellent :)",
                    ProductId=11,
                    CreatedOn=DateTime.Now,
                },
                        new Review()
                {
                    Id = 6,
                    UserId="cd0f2b40-9353-405c-ae22-c1097419f287",
                    Text="Excellent ,Thank you:)",
                    ProductId=11,
                    CreatedOn=DateTime.Now,
                },
                                new Review()
                {
                    Id = 7,
                    UserId="cd0f2b40-9353-405c-ae22-c1097419f287",
                    Text="It`s really expensive for its quality ",
                    ProductId=12,
                    CreatedOn=DateTime.Now,
                },
                                new Review()
                {
                    Id = 8,
                    UserId="cd0f2b40-9353-405c-ae22-c1097419f287",
                    Text="Low quality ,not impressed :(",
                    ProductId=4,
                    CreatedOn=DateTime.Now,
                },
                                                new Review()
                {
                    Id = 9,
                    UserId="cd0f2b40-9353-405c-ae22-c1097419f287",
                    Text="Low quality ,not impressed :(",
                    ProductId=7,
                    CreatedOn=DateTime.Now,
                },
                                                                               new Review()
                {
                    Id = 10,
                    UserId="04fa2e1b-1e98-42fa-b709-f364b63cfa91",
                    Text="Low quality ,not impressed :(",
                    ProductId=9,
                    CreatedOn=DateTime.Now,
                },
                                                                                       new Review()
                {
                    Id = 11,
                    UserId="04fa2e1b-1e98-42fa-b709-f364b63cfa91",
                    Text="Low quality ,not impressed :(",
                    ProductId=3,
                    CreatedOn=DateTime.Now,
                },
                                                                                                         new Review()
                {
                    Id = 12,
                    UserId="727a36c2-e76e-4764-a9f6-9402f63c7872",
                    Text="Very good ,thanks",
                    ProductId=4,
                    CreatedOn=DateTime.Now,
                },
            new Review()
            {
                Id = 13,
                UserId = "727a36c2-e76e-4764-a9f6-9402f63c7872",
                Text = "Very good ,thanks",
                ProductId = 5,
                CreatedOn = DateTime.Now,
            },
            new Review()
                {
                    Id = 14,
                    UserId="727a36c2-e76e-4764-a9f6-9402f63c7872",
                    Text="Very good ,thanks",
                    ProductId=8,
                    CreatedOn=DateTime.Now,
                },
            new Review()
                {
                    Id = 15,
                    UserId="727a36c2-e76e-4764-a9f6-9402f63c7872",
                    Text="Not recommend :(",
                    ProductId=9,
                    CreatedOn=DateTime.Now,
                },
            new Review()
                {
                    Id = 16,
                    UserId="727a36c2-e76e-4764-a9f6-9402f63c7872",
                    Text="Not recommend :(",
                    ProductId=10,
                    CreatedOn=DateTime.Now,
                },
        };
            return reviews;
        }
    }
}
