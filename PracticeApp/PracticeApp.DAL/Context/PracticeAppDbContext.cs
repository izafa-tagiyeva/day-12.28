using Azure;
using Microsoft.EntityFrameworkCore;
using PracticeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.DAL.Context
{
    public class PracticeAppDbContext : DbContext
    {

        public PracticeAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
