using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Part1_Relation
{
    class Program
    {//eager loading
        static void Main(string[] args)
        {
            SampleContext context = new SampleContext();
            Book book = new Book()
            {
                Title = "Perl Programming",
               AuthorId=1
            };
            context.Books.Add(book);
            context.SaveChanges();
            Console.WriteLine("Done!!!");
            Console.Read();

        }

        private static void EagerLoadDemo()
        {
            SampleContext context = new SampleContext();
            var data = context.Authors.Include(a => a.Books).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
                if (item.Books != null)
                {
                    Console.WriteLine("Books");
                    foreach (var book in item.Books)
                    {
                        Console.WriteLine(book.Title);
                    }
                }

                Console.WriteLine("------------------------------");
            }
        }

        private static void InsertBook2(SampleContext context)
        {
            Book book = new Book()
            {
                Title = "Python Programming",
                Author = new Author()
                {
                    AuthorId = 1,
                    FirstName = "amir",
                    LastName = "amiri"
                }
            };
            context.Books.Add(book);
        }

        private static void InsertBook1(SampleContext context)
        {
            Author author = context.Authors.Find(1);
            Book book = new Book()
            {
                Title = "C# Programming",
                Author = author
            };
            context.Books.Add(book);
        }

        private static void InsertAuthor1(SampleContext context)
        {
            context.Authors.Add(new Author()
            {
                FirstName = "amir",
                LastName = "amiri"


            });
        }
    }
}
