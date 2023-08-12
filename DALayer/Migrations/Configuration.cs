namespace DALayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DALayer.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //update-database demeden önce burası true 
        }

        protected override void Seed(DALayer.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
