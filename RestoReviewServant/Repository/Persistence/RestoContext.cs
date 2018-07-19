using RestoReviewService.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RestoReviewService.Repository.Persistence
{
    public class RestoContext : DbContext
    {
        public RestoContext() : base("RestoReviewTest")
        {
            // This solves the issue that WCF has problems with EF during serialization due to lazy loading.
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Restaurant> Restos { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Category> Category { get; } // read-only

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}