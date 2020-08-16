namespace MediaFileTask.Migrations
{
    using MediaFileTask.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MediaFileTask.Models.MediaFileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MediaFileTask.Models.MediaFileContext context)
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

            context.MediaFiles.AddOrUpdate(
                    new MediaFile() { Duration = 1234, Name = "abc", Size = 150 },
                    new MediaFile() { Duration = 140, Name = "404", Size = 183 }
                );
        }
    }
}
