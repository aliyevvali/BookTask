using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PublisherBook> PublisherBooks { get; set; }
    }
}
