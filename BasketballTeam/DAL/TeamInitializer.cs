using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BasketballTeam.Models;

namespace BasketballTeam.DAL
{
    public class TeamInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeamContext>
    {
        protected override void Seed(TeamContext context)
        {
            var players = new List<Player>

        {
            new Player { FirstName = "Lebron", LastName = "James" },
            new Player { FirstName = "Chris", LastName = "Paul" },
            new Player { FirstName = "Brook", LastName = "Lopez" }

            };

        players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();
        }
    }
}