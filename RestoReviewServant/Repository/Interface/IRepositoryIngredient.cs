using RestoReviewService.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoReviewService.Repository.Interface
{
    public interface IRepositoryIngredient : IRepository<Ingredient>
    {
        IEnumerable<Ingredient> GetIngredientsByCategory(string categoryName);
        IEnumerable<Ingredient> GetAllIngredientsWithCategory();
    }
}