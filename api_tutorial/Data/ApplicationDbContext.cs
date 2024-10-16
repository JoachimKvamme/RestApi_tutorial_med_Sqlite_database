using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_tutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_tutorial.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }
        public DbSet<Stock> Stock {get; set;}
        public DbSet<Comment> Comment {get; set;}
    }
}