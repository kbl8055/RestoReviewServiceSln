using RestoReviewService.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestoReviewService.Repository.Persistence
{
    public class RestoInitializer : DropCreateDatabaseIfModelChanges<RestoContext>
    {
        protected override void Seed(RestoContext context)
        {
            SeedEntities(context);
        }

        private void SeedEntities(RestoContext context)
        {
            SeedRestaurants(context);
            SeedCategories(context);
            SeedIngredients(context);
        }

        private void SeedIngredients(RestoContext context)
        {
            var ingredients = new List<Ingredient>
            {
                new Ingredient {
                    Name = "Garlic",
                    Description = "Pungent flavor as a seasoning or condiment.",
                    Price = 85m,
                    UnitOfMeasure = "Kg",
                    CategoryId = 1
                },
                new Ingredient {
                    Name = "Laurel",
                    Description = "A bay leaf used for seasoning in cooking.",
                    Price = 100m,
                    UnitOfMeasure = "Kg",
                    CategoryId = 1
                },
                new Ingredient {
                    Name = "Black Ground Pepper",
                    Description = string.Concat("Coming from the berries of the pepper plant, ", 
                                                "this spice adds both heat and depth of flavor to nearly any dish."),
                    Price = 80m,
                    UnitOfMeasure = "Kg",
                    CategoryId = 1
                },
            };

            ingredients.ForEach(e => context.Ingredients.Add(e));
            context.SaveChanges();
        }

        private void SeedCategories(RestoContext context)
        {
            var categories = new List<Category>
            {
                new Category {
                    Name = "Vegetable",
                    Description = "Roots, leaves and stems."
                },
                new Category {
                    Name = "Meat",
                    Description = "Flesh from animals considered as food."
                },
                new Category {
                    Name = "Dairy",
                    Description = "Food processed using milk."
                }
            };

            categories.ForEach(e => context.Category.Add(e));
            context.SaveChanges();
        }

        private void SeedRestaurants(RestoContext context)
        {
            var restos = new List<Restaurant>
            {
                new Restaurant {
                    Name = "Jollibee",
                    MainOffice = "Somewhere st., Ortigas, Pasig City",
                    Description = "McDonald's immitator"
                },
                new Restaurant {
                    Name = "Master's Shawarma",
                    MainOffice = "Somewhere st., Eastwood City, Libis, Quezon City",
                    Description = "Started with shawarma and beef pares."
                },
                new Restaurant {
                    Name = "Turk's Shawarma",
                    MainOffice = "Somewhere st., Commonwealth Ave., North Fairview, Quezon City",
                    Description = "Serves shawarma kebab."
                },
                new Restaurant {
                    Name = "<-Mag-Ka-nu-to?->",
                    MainOffice = "Somewhere st., Eastwood City, Libis, Quezon City",
                    Description = "Started with shawarma and beef pares."
                },
            };

            restos.ForEach(e => context.Restos.Add(e));
            context.SaveChanges();
        }
    }
}