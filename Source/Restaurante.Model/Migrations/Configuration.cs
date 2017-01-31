namespace Restaurante.Model.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.Context.RestauranteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Restaurante.Model.Context.RestauranteContext";
        }

        protected override void Seed(Model.Context.RestauranteContext context)
        { }
    }
}
