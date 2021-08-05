using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Book> Books { get; set; }

        public Library(string name, string address)
        {

            Name = name;
            Address = address;
        
        }
        public Library()
        { 
        
        }

        public Library(string name, string address, List<Book> books) : this(name, address)
        {
            Books = books;
        }
        public void addBook(Book book)
        {
            Books.Add(book);
        }
        public bool removeBook(Book book)
        {

            if (Books.Contains(book))
            {
                Books.Remove(book);
                return true;
            }
            else {
                return false;
            }
        }
        public List<Book> GetBooksYear(int year)
        {
            List<Book> books1 = new List<Book>();

            books1 = Books.Where(p => p.PublishDate.Year > year).ToList();

            return books1;
        }
        public List<Book> GetBookscategory(string category)
        {

            List<Book> books1 = new List<Book>();

            books1 = Books.Where(p => p.Categories.Contains(category)).ToList();
            return books1;
        }

        public List<String> GetAuthors(int nr)
        {

            var authors = new List<Author>();
            authors = Books.Select(p => p.AuthorofBook).ToList();
            //get a list of all authors
            authors = authors.Where(p => authors.Count(c => c == p)>=nr).ToList().Distinct().ToList();
            //get a list of all authors who written more than "nr" books
            List<String> names = new List<string>();
            names = authors.Select(c => c.Name).ToList();
            return names;
        }
        public List<String> getAuthorsByNrAndCat(int nr,int year, string category)
        {
            // nr - number of books, in example 2
            // year - year search, in example 1990
            // category -  category of book, in example "science-fiction"
            var books = new List<Book>();
            books= GetBookscategory(category);
            //Get a list of all the books that belong to a specified category
            var authors = new List<Author>();
            authors = books.Select(p => p.AuthorofBook).ToList();
            //get a list of all athors of the books that belong to a specified category
            authors = authors.Where(p => ((authors.Count(c => c == p) >= nr)&& (p.DateOfBorn.Year<=year))).ToList().Distinct().ToList();
            //Get the list of all authors that are born before "years" and have written at least "nr" books of a specified category 
            List<String> names =authors.Select(c => c.Name).ToList();
            //Get a list of  the names of all authors that are born before "year" and have written at least "nr" books of specified category 
            return names;
        }

        public IEnumerable<IGrouping<int, Book>> getBooksGroupedByDecade()
        {
            var books = Books.GroupBy(p=>p.PublishDate.Year/10);
            return books;
        }
        public override string ToString()
        { StringBuilder books = new StringBuilder();
            foreach (var a in Books)
            {
                books.Append(a.Title);
                books.Append(" ");
            }
            if(books.Length>0)
            {
               
                books[books.Length-1] = '.';

            }
           
            return $@"Name:{Name};
Location: {Address};
Books:{books}";
        }
    }
}
