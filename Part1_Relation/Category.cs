using System.Collections.Generic;

namespace Part1_Relation
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
