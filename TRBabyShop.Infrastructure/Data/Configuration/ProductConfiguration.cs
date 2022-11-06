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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(CreateProducts());
        }

        private List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id=1,
                    Name="Baby Touch Magic Bath Book",
                    Description="Dip me in water and watch me change colour",
                    Price= 8.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/house-of-marbles-books-baby-touch-magic-bath-book-33551194849445_1024x1024@2x.jpg?v=1664889397",
                    CategoryId=1,
                },
                new Product()
                {
                    Id=2,
                    Name="The Wonderful Things You Will Be - Book",
                    Description="Filled with beautiful, quirky illustrations and clever read-aloud rhyme, grown-ups will love reading this book to their children at any age as they lovingly consider all the possibilities that lie ahead. Its enduring message of love and acceptance as children grow and change is both universal and poignant, and is one to share over and over again.",
                    Price= 13.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/house-of-marbles-books-the-wonderful-things-you-will-be-book-33551190360229_1024x1024@2x.jpg?v=1664889390",
                    CategoryId=1,
                },
                new Product()
                {
                 Id=3,
                    Name="Bugaboo Turtle Air by Nuna Car Seat - Black",
                    Description="Bugaboo Turtle Air by Nuna is our ultralight car seat solution for safely transporting your newborn, from their very first ride to the everyday journeys to follow. Designed in collaboration with premium brand Nuna, it offers top comfort for your baby and seamless integration with your Bugaboo stroller. This item includes the car seat (you can purchase the Bugaboo 360 Base separately).",
                    Price= 199M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/bugaboo-bugaboo-turtle-air-by-nuna-car-seat-black-33556696203429_1024x1024@2x.jpg?v=1664980829",
                    CategoryId=2,
                },

                new Product()
                {
                 Id=4,
                    Name="Maxi-Cosi Mica Eco i-Size - Authentic Black",
                    Description="The Mica Eco has been designed to provide convenience, safety and sustainability. The seat?s 360° rotation makes it much easier to get your children in and out of the car every day, without straining your back. Made to meet the highest i-Size safety standards, the Mica Eco features G-CELL Side Impact Protection and Eco Care 100% recycled fabrics, to safeguard a better tomorrow.",
                    Price= 259.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/maxi-cosi-maxi-cosi-mica-eco-i-size-authentic-black-33536085917861_1024x1024@2x.jpg?v=1664532268",
                    CategoryId=2,
                },

                new Product()
                {
                 Id=5,
                    Name="Sassy Silicone Flower Rattle Teether",
                    Description="Crafted from 100% textured silicone, this petal shaped teether will give your little one's sore gums relief whilst they're teething. Each petal offers a different texture to explore, with a rainbow of colours and a rattle inside to add visual and sound stimulation.",
                    Price= 8.49M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-silicone-flower-rattle-teether-32104732688549_1024x1024@2x.jpg?v=1638282702",
                    CategoryId=3,
                },

                new Product()
                  {
                 Id=6,
                    Name="Sassy Light-Up Rainbow Reel Spinning Developmental Tray Toy - 6+ Months",
                    Description="Stick the suction base of this spinning toy to any flat smooth surface and spin the wheel. The soft exterior bumps make spinning easy for baby, who will love watching the rainbow appear as the wheel spins. ",
                    Price= 13.79M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-light-up-rainbow-reel-spinning-developmental-tray-toy-6-months-32104676753573_1024x1024@2x.jpg?v=1638282346",
                    CategoryId=3,
                },

                 new Product()
                  {
                 Id=7,
                    Name="MAM Baby 6-in-1 Electric Steriliser & Large Bottle Starter Bundle - Matt Taupe",
                    Description="This innovation from MAM Baby features six valuable functions all in one product. Forget having to invest and store a steriliser and a bottle warmer separately, simply choose MAM for all your needs.",
                    Price= 165M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mam-bottle-feeding-mam-baby-6-in-1-electric-steriliser-large-bottle-starter-bundle-32845940195493_1024x1024@2x.jpg?v=1652788714",
                    CategoryId=4,
                },

                 new Product()
                  {
                 Id=8,
                    Name="Babymoov Turbo Pure Steriliser and Bottle Dryer - Blue",
                    Description="Steriliser, dryer and bottle storage in a purified environment",
                    Price= 89.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/sassy-sassy-light-up-rainbow-reel-spinning-developmental-tray-toy-6-months-32104676753573_1024x1024@2x.jpg?v=1638282346",
                    CategoryId=4,
                },

                 new Product()
                  {
                 Id=9,
                    Name="Babymoov Premium Care Audio Monitor - Black & White",
                    Description="Thanks to Digital Green Technology, the Premium Care baby monitor combines the performance of digital technology (zero interference and clear digital sound) with low-wave emission levels to ensure baby is safe at all times. The stylish LCD touchscreen is easy to use, and the added bonus of the nightlight assist with settling baby too.",
                    Price= 81.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/babymoov-baby-monitors-babymoov-premium-care-audio-monitor-black-white-32248768888997_1024x1024@2x.jpg?v=1640097653",
                    CategoryId=5,
                },

                  new Product()
                  {
                 Id=10,
                    Name="Angelcare AC527 Baby Movement Monitor with Video & Sound",
                    Description="The Angelcare® AC527 Baby Movement Monitor, with Video is a dependable, trusted and beautifully designed baby care essential. It has Angelcare®'s new 40% smaller Wireless SensAsure Movement Sensor Pad. Rest assured, the pad offers the exact same precise levels of movement detection.",
                    Price= 121.99M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/angelcare-baby-monitors-angelcare-ac527-baby-movement-monitor-with-video-sound-31667682934949_1024x1024@2x.jpg?v=1634220465",
                    CategoryId=5,
                },

                  new Product()
                  {
                 Id=11,
                    Name="Welcome to the World Farm Yard Dreampod - Blue Farm Print",
                    Description="Introduce your little one to their nursery in soft, reassuring style. Mamas & Papas' Welcome to the World interiors collection is our much-loved, bestselling range. This new-look collection embraces soft pastel shades and cute woodland characters for pieces that are soft to touch and gentle against baby's sensitive skin.",
                    Price= 25M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-welcome-to-the-world-farm-yard-dreampod-blue-farm-print-29480443084965_1024x1024@2x.jpg?v=1628835782",
                    CategoryId=6,
                },

                   new Product()
                  {
                 Id=12,
                    Name="Dreampod Sleep Bag 0-6 Months 2.5 Tog (Pack of 2) - Balloon",
                    Description="Keep your little one wrapped up warm this winter with our two pack of Dream Pod Sleep bags. Perfect for those colder nights, the zip and button-fastening design is safer than loose bedding, while the 2.5 Tog padding is sure to keep them toasty. Made with 100% jersey cotton, they're super soft and cosy, while also being gentle against baby's sensitive skin.",
                    Price= 45M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/mamas-papas-dreampod-sleep-bags-swaddling-dreampod-sleep-bag-0-6-months-2-5-tog-pack-of-2-balloon-18930240389285_1024x1024@2x.jpg?v=1619068305",
                    CategoryId=6,
                },

                     new Product()
                  {
                 Id=13,
                    Name="Tommee Tippee Complete Feeding Kit White",
                    Description="Our Complete Feeding Set contains everything you need to make baby feeding straightforward. Closer to Nature bottles have the most breast-like teat ever made. It flexes and feels like mum, so switching between breast and bottle feeding is a stress-free experience. Our Advanced Steam Steriliser can sterilise up to 6 bottles in just 5 minutes, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories.",
                    Price= 28M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-complete-feeding-kit-white-29069097992357_1024x1024@2x.jpg?v=1628424110",
                    CategoryId=7,
                },

                        new Product()
                  {
                 Id=14,
                    Name="Tommee Tippee Anti Colic Complete Feeding Kit - White",
                    Description="The kit includes our Advanced Steam Steriliser which can sterilise up to 6 bottles in just 5 minutes flat, killing 99.9% of germs that may linger in bottles, teats, breast pumps and other baby feeding accessories. ",
                    Price= 78M,
                    Image="https://cdn.shopify.com/s/files/1/0414/6023/6453/products/tommee-tippee-bottle-feeding-tommee-tippee-anti-colic-complete-feeding-kit-white-29071235186853_1024x1024@2x.jpg?v=1628434206",
                    CategoryId=7,
                },
            };

            return products;
        }
    }
}
