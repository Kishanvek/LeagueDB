using LeagueDB.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LeagueDB.DAL
{
    public class LeagueDBContext : DbContext
    {
        public LeagueDBContext() : base("LeagueDBContext") //name of connectoin string
        {
        }

        public DbSet<Champion> Champions { get; set; }
        public DbSet<Build> Builds { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}