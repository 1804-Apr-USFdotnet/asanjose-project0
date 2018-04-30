using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DataStuff
{


    public class Model1 : DbContext
    {
        public Model1() : base("name=Model1")
        {
        }

        public DbSet<Restaurants> restaurants { get; set; }
        public DbSet<Reviews> reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }

}
