using BookTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.DAL
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=DESKTOP-J0OVA9S\SQLEXPRESS;Database=Book;Trusted_Connection=True;");           
        }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGener> BookGeners { get; set; }
        public DbSet<PublisherBook> PublisherBooks { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<SoldBook> SoldBooks { get; set; }


    }
}
