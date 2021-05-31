﻿using System.Collections.Generic;

namespace Part1_Relation
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }

        public AuthorBiography  AuthorBiography { get; set; }
    }
}
