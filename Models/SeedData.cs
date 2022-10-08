using e_commerce_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_app.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CommerceDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<CommerceDbContext>>()))
            {
                if (context.Products.Any()) return;

                context.Products.AddRange(
                new Product
                {
                    Name = "Tanjun Black",
                    SKU = "11111",
                    Price = 200M,
                    Description = "Nike Women's Tanjun Black/MTLC/Red/Bronze Running Shoe 6 Women US",
                    ImgUrl = "/Assets/61q7yA5kNlL._UX679_.jpg",
                },

                new Product
                {
                    Name = "GIORDANO",
                    SKU = "22222",
                    Price = 250M,
                    Description = "GIORDANO Shoes for Men",
                    ImgUrl = "/Assets/61O94OF9mUL._UY695_.jpg",
                },

                new Product
                {
                    Name = "ASIAN Wonder",
                    SKU = "33333",
                    Price = 350M,
                    Description = "ASIAN Men's Wonder-13 Sports Running Shoes",
                    ImgUrl = "/Assets/61utX8kBDlL._UY675_.jpg",
                },

                new Product
                {
                    Name = "Nike Mens React",
                    SKU = "44444",
                    Price = 450M,
                    Description = "Nike Mens React-Type GTX Gore-tex Running Shoe",
                    ImgUrl = "/Assets/7102q4bLwFL._UX535_.jpg",
                },

                new Product
                {
                    Name = "Nike Mens Air",
                    SKU = "55555",
                    Price = 350M,
                    Description = "Nike Mens Air Zoom Pegasus 38 Running Shoe",
                    ImgUrl = "/Assets/71twGCoVvVS._UX675_.jpg",
                },

                new Product
                {
                    Name = "Adidas Unisex-Adult",
                    SKU = "66666",
                    Price = 700M,
                    Description = "Adidas Unisex-Adult Runfalcon 2.0 Shoes",
                    ImgUrl = "/Assets/71i4S0aVsPL._UX535_.jpg",
                },

                new Product
                {
                    Name = "Adidas Men's Hellion",
                    SKU = "77777",
                    Price = 500M,
                    Description = "Adidas Men's Hellion Z M Running Shoe",
                    ImgUrl = "/Assets/712AsoD8uTL._UX675_.jpg",
                },

                new Product
                {
                    Name = "Adidas Womens Effortso",
                    SKU = "88888",
                    Price = 430M,
                    Description = "Adidas Womens Effortso W Running Shoes",
                    ImgUrl = "/Assets/71jeXaw3dwL._UX535_.jpg",
                },

                new Product
                {
                    Name = "Adidas Womens Contemx",
                    SKU = "99999",
                    Price = 520M,
                    Description = "Adidas Womens Contemx W Shoes",
                    ImgUrl = "/Assets/71bQRXY3PsL._UX535_.jpg",
                },

                new Product
                {
                    Name = "Puma Softride",
                    SKU = "1010101010",
                    Price = 290M,
                    Description = "Puma Softride Rift Slip-on Bold Men's Running",
                    ImgUrl = "/Assets/81LIKsyHCGS._UX675_.jpg",
                });

                context.SaveChanges();
            }
        }
    }
}
