using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class BookGener
    {

        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenerId { get; set; }
        public Book book { get; set; }
        public Genre genre { get; set; }
    }
}
