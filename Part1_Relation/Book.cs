using System.Collections.Generic;

namespace Part1_Relation
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public int? AuthorId { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
