﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MexicoFacts.Domain;

namespace MexicoFacts.Data
{
    public class MexicoFactsContext : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<Fact> Facts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=MexicoFactsData");
           
        }
    }
}
