using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public int PageCount { get; set; }


        public List<BookGener> BookGeners { get; set; }
        public List<PublisherBook> PublisherBooks { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
        

    }
}
