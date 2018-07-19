using RestoReviewService.Business;
using RestoReviewService.Repository.Interface;
using RestoReviewService.Repository.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoReviewService.Repository
{
    public class RepositoryIngredient : Repository<Ingredient>, IRepositoryIngredient
    {
        public RestoContext RestoContext => _context as RestoContext;

        public RepositoryIngredient(RestoContext context) : base(context)
        {
        }

        public IEnumerable<Ingredient> GetIngredientsByCategory(string categoryName)
        => RestoContext.Ingredients.Where(e => e.Category.Name.ToLower() == categoryName);
    }
}