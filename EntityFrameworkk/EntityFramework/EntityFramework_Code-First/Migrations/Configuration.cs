using System.Data.Entity.Migrations;

namespace EntityFramework_Code_First.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework_Code_First.Northwind>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework_Code_First.Northwind context)
        {
            context.Categories.AddOrUpdate(
              new Categories() { CategoryName = "pew" },
              new Categories { CategoryName = "pow" },
              new Categories { CategoryName = "puw" }
            );

            context.Regions.AddOrUpdate(
                new Regions() { RegionDescription = "Mikitka"}
                );

            context.Territories.AddOrUpdate(
                new Territories() { RegionID = 2 , TerritoryDescription = "asd"}
                );
        }
    }
}
