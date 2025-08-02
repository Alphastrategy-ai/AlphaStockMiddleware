
using AlpaStock.Core.Context;
using AlpaStock.Core.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace AlpaStock.Core.Seeder
{
    public class Seeder
    {
        public static async Task SeedData(IApplicationBuilder app)
        {
            var dbContext = app.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<AlphaContext>();

            if (dbContext.Database.GetPendingMigrations().Any())
            {
                dbContext.Database.Migrate();
            }

            if (!dbContext.Roles.Any())
            {
                await dbContext.Database.EnsureCreatedAsync();
                var roleManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                List<string> roles = new() { "Admin", "User" };
                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
                }
            }
            if (!dbContext.Subscriptions.Any())
            {

                var AddSubPlan = await dbContext.Subscriptions.AddAsync(new Subscription()
                {
                    Id = "314561df-5e86-4269-b97e-d3f55b5d3e99",
                    Amount = 0,
                    DiscountRate = 0,
                    BillingInterval = "1",
                    IsDIscounted = false,
                    Name = "Free",
                });
                var ListStock = new Dictionary<string, string>
                {
                    { "SA", "Stock Analysis" },
                    { "DT", "Data Table" },
                    { "R", "Result" }
                };

                foreach (var item in ListStock)
                {
                    await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                    {
                        SubscriptionId = AddSubPlan.Entity.Id,
                        Category = "Stock Analysis",
                        CurrentState = "True",
                        FeatureName = item.Value,
                        ShortName = item.Key
                    });
                }
                var dicFinance = new Dictionary<string, string>
                {
                    { "BS", "Balance Sheet" },
                    { "CF", "Cash Flow" },

                }; foreach (var item in dicFinance)
                {
                    await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                    {
                        SubscriptionId = AddSubPlan.Entity.Id,
                        Category = "Financial Insight",
                        CurrentState = "True",
                        FeatureName = item.Value,
                        ShortName = item.Key
                    });
                }
                var Fundamentals = new Dictionary<string, string>
                {
                    { "AF", "Alpha Fundamentals" },
                    { "MY", "My Fundamentals" },

                }; foreach (var item in Fundamentals)
                {
                    await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                    {
                        SubscriptionId = AddSubPlan.Entity.Id,
                        Category = "Fundamentals",
                        CurrentState = "True",
                        FeatureName = item.Value,
                        ShortName = item.Key
                    });
                }
                var metrics = new Dictionary<string, string>
                {
                    { "ST", "Stock Charts" },
                    { "SN", "Stock News" },
                    { "AN", "Annual Reports" },

                };

                foreach (var item in metrics)
                {
                    await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                    {
                        SubscriptionId = AddSubPlan.Entity.Id,
                        Category = "Metrics",
                        CurrentState = "True",
                        FeatureName = item.Value,
                        ShortName = item.Key
                    });
                }

                await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                {
                    SubscriptionId = AddSubPlan.Entity.Id,
                    Category = "Financial Insight",
                    CurrentState = "0 per month",
                    FeatureName = "Income Statement",
                    ShortName = "IS"
                });
                await dbContext.SubscriptionFeatures.AddAsync(new SubscriptionFeatures
                {
                    SubscriptionId = AddSubPlan.Entity.Id,
                    Category = "Community Management",
                    CurrentState = "True",
                    FeatureName = "Community Management",
                    ShortName = "CM"
                });
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
