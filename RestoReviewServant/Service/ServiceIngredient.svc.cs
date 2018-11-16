using RestoReviewService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestoReviewService.Business;
using RestoReviewService.Repository.Persistence;
using Newtonsoft.Json;

namespace RestoReviewService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceIngredient" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceIngredient.svc or IngredientService.svc.cs at the Solution Explorer and start debugging.
    public class ServiceIngredient : IServiceIngredient
    {
        public void AddIngredient(Ingredient ingredient)
        {
            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                restoContext.Ingredients.Add(ingredient);
                restoContext.Persist();
            }
        }

        public void DeleteIngredient(int id)
        {
            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                var ingredient = restoContext.Ingredients.Get(id);
                restoContext.Ingredients.Remove(ingredient);
                restoContext.Persist();
            }
        }

        public Ingredient EditIngredient(Ingredient ingredient)
        {
            Ingredient sourceIngredient;

            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                sourceIngredient = restoContext.Ingredients.Get(ingredient.Id);
                sourceIngredient.Name = ingredient.Name;
                sourceIngredient.Description = ingredient.Description;
                sourceIngredient.CategoryId = ingredient.CategoryId;
                sourceIngredient.Price = ingredient.Price;
                sourceIngredient.UnitOfMeasure = ingredient.UnitOfMeasure;
                restoContext.Persist();
            }

            return sourceIngredient;
        }

        public List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients;

            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                ingredients = restoContext.Ingredients.GetAll().ToList();
            }

            return ingredients;
        }

        public List<Ingredient> GetIngredientsByCategory(string categoryName)
        {
            List<Ingredient> ingredients;

            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                ingredients = restoContext.Ingredients.GetIngredientsByCategory(categoryName).ToList();
            }

            return ingredients;
        }

        public List<Ingredient> GetAllIngredientsWithCategory()
        {
            //string ingredientsWCategory;

            //using (var restoContext = new UnitOfWork(new RestoContext()))
            //{
            //    var ingredients = restoContext.Ingredients.GetAllIngredientsWithCategory().ToList();
            //    ingredientsWCategory = JsonConvert.SerializeObject(ingredients);
            //}

            //return ingredientsWCategory;

            List<Ingredient> ingredients;

            using (var restoContext = new UnitOfWork(new RestoContext()))
            {
                ingredients = restoContext.Ingredients.GetAllIngredientsWithCategory().ToList();
            }

            return ingredients;
        }

        //public List<Category> GetCategories()
        //{
        //    List<Category> categories;

        //    using (var restoContext = new UnitOfWork(new RestoContext()))
        //    {
        //        //categories = restoContext.Categories.ToList();
        //        //categories = restoContext.Categories.GetAll().ToList();
        //        categories = null;
        //    }

        //    return categories;
        //}
    }
}
