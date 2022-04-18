﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask.Models
{
    class AuthorBook
    {

        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}