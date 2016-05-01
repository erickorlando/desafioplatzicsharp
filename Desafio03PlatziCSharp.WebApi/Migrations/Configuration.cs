namespace Desafio03PlatziCSharp.WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Desafio03PlatziCSharp.WebApi.Models.Desafio03PlatziCSharpWebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Desafio03PlatziCSharp.WebApi.Models.Desafio03PlatziCSharpWebApiContext";
        }

        protected override void Seed(Desafio03PlatziCSharp.WebApi.Models.Desafio03PlatziCSharpWebApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
