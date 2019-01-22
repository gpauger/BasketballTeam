using BasketballTeam.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BasketballTeam.DAL
{
    public class TeamContext : DbContext
    {

        public TeamContext() : base("TeamContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Stats> Statistics { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}