using Database1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Database1.DAL
{
    public class BasketballContext : DbContext //same name as the object in the connection string area
    {   //inherits from database connection string
        public BasketballContext()
            : base("BasketballContext") // calls the parent constructor. Pass it a string 'Basketball Context'
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<NewPlayer> NewPlayers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}