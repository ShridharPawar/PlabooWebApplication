using Plaboo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Plaboo.Context
{
    public class PlabooContext : DbContext
    {

        //this will have individual datasets for every existing table in the database
        public PlabooContext() : base("name=DBConnection")
        {
        }
        public DbSet<Plastic> Plastics { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<councilRate> councilRates { get; set; }

        public DbSet<allCouncilPostcode> allCouncilPostcodes { get; set; }
    }
}