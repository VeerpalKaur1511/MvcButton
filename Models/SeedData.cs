using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcButton.Data;
using System;
using System.Linq;

namespace MvcButton.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcButtonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcButtonContext>>()))
            {
                // Look for any button.
                if (context.Button.Any())
                {
                    return;   // DB has been seeded
                }

                context.Button.AddRange(
                    // here's my seeddata for my button apllication.
                    new Button
                    {
                        Title = "Enamel buttons",
                        Size = 2.7M,
                        Materials = "Wood",
                        Color = "Pink",
                        Price = 8.5M
                    },

                    new Button
                    {
                        Title = "Porcelain buttons",
                        Size = 3.9M,
                        Materials = "Plastic",
                        Color = "Green",
                        Price = 9.0M
                    },


                    new Button
                    {
                        Title = "Corozo buttons",
                        Size = 4.5M,
                        Materials = "Metal",
                        Color = "Blue",
                        Price = 6.6M
                    },

                    new Button
                    {
                        Title = "Horn buttons",
                        Size = 5.9M,
                        Materials = "Fabric",
                        Color = "Brown",
                        Price = 1.7M
                    },
                    new Button
                    {
                        Title = "Shell buttons",
                        Size = 3.9M,
                        Materials = "Leather",
                        Color = "Red",
                        Price = 4.1M
                    },
                    new Button
                    {
                        Title = "Toggles",
                        Size = 1.9M,
                        Materials = "Glass",
                        Color = "Black",
                        Price = 8.4M
                    },
                    new Button
                    {
                        Title = "4-hole flat buttons",
                        Size = 2.8M,
                        Materials = "Paper",
                        Color = "White",
                        Price = 7.33M
                    },
                    new Button
                    {
                        Title = "Stud buttons",
                        Size = 8.6M,
                        Materials = "Chinese knotted",
                        Color = "Yellow",
                        Price = 13.6M
                    },
                    new Button
                    {
                        Title = "Shank buttons",
                        Size = 6.7M,
                        Materials = "Plastic",
                        Color = "Orange",
                        Price = 84.2M
                    },
                    new Button
                    {
                        Title = "2-hole flat buttons",
                        Size = 7.7M,
                        Materials = "Wood",
                        Color = "Grey",
                        Price = 57.3M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}