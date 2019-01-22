using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasketballTeam.Models
{
    public class Stats
    {
        public int ID { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Assists { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
        public int FgPercentage { get; set; }
        public int FtPercentage { get; set; }
    }
}