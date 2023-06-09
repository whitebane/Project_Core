﻿using E_LAYER.Concrete;
using Microsoft.EntityFrameworkCore;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KAANPC;database=BlogDB; User Id=sa; Password=meta1234; TrustServerCertificate=true;");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }


    }
}
