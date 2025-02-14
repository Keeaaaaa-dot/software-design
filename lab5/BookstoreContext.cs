using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace lab5
{
    public class BookstoreContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Kean;Database=BookstoreDB;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)  // Book has one Author
                .WithMany(a => a.Books)  // Author has many Books
                .HasForeignKey(b => b.AuthorID);  // Foreign key to Author
        }
    }


    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }


    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}
