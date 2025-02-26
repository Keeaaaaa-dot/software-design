using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using static lab5.Form1;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookstoreDB;Trusted_Connection=True;");
        }



    }
}
