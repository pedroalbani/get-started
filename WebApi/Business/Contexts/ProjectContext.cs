using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Business.Contexts
{
    public class ProjectContext : DbContext
    {

        public ProjectContext() : base("get_started")
        {

        }

        public ProjectContext(string connection) : base(connection)
        {

        }

        //Configurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configure the IDs as Key 
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            //Configure the Strings as varchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }

    }
}