using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class PublisherBook
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int BookId { get; set; }

        public Publisher Publisher { get; set; }
        public Book Book { get; set; }
    }
}
