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
        public PlabooContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Plastic> Plastics { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

    }
}