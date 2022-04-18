using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class Author
    {
        public int Id { get; set; }
        public string SurnameName { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
    }
}
