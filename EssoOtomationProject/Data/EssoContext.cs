﻿using EssoOtomationProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace EssoOtomationProject.Data
{
    public class EssoContext : DbContext
    {
        public EssoContext(DbContextOptions<EssoContext> options) : base(options)
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

       
    }
}

