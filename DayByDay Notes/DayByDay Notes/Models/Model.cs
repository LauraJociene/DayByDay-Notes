﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DayByDay_Notes

{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Blogging.db");
        }
    }
    
}