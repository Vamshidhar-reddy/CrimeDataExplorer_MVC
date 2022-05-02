﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4.Models;
//using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using static Assignment4.Models.CrimeRecord;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
//using System.Data.Entity;

namespace Assignment4.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
      
        public DbSet<CrimeRecord> Crimes { get; set; }
       
        public DbSet<Crime> Crime { get; set; }

    }
}