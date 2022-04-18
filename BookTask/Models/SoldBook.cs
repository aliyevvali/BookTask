using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class SoldBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BookCount { get; set; }
        public Book Book { get; set; }
        
    }
}
