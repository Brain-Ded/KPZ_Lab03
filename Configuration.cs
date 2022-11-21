namespace KPZ_Lab03CF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KPZ_Lab03CF.StudentCF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "KPZ_Lab03CF.StudentCF";
        }

        protected override void Seed(KPZ_Lab03CF.StudentCF context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
