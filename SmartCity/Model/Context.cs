using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Model
{
    public class Context:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryInfrastructure> CategoryInfrastructures { get; set; }
        public DbSet<CurrentLocation> CurrentLocations { get; set; }
        public DbSet<Infrastructure> Infrastructures { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<TypeInfrastructure> TypeInfrastructures { get; set; }

        //public Context():base("name=ConnectionAzure")
        public Context() : base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany<User>(p => p.Friends)
                .WithMany(a => a.Friends)
                .Map(
                    ap =>
                    {
                        ap.MapLeftKey("UserLeft");
                        ap.MapRightKey("UserRight");
                        ap.ToTable("Friends");
                    }
                );*/

            modelBuilder.Entity<User>()
                .HasOptional(u => u.CurrentLocation)
                .WithRequired();
        }
    }

}
