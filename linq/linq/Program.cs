using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateRobert = new DateTime(1980, 10, 22);
            DateTime dateGoleman = new DateTime(1950, 11, 23);
            DateTime dateJoe = new DateTime(1977, 12, 23);
            DateTime dateMel = new DateTime(1995, 12, 23);
            DateTime dateMark = new DateTime(1985, 12, 23);
            DateTime datePublishofArt = new DateTime(2020, 12, 23);
            DateTime dateEverythingisf = new DateTime(2021, 2, 11);
            DateTime date5secondRules = new DateTime(2010, 2, 3);
            DateTime dateYouAreFine = new DateTime(2005, 12, 3);
            DateTime dateTrainYourBrain = new DateTime(2000, 4, 13);
            DateTime dateBecomingSupernatural = new DateTime(1880, 4, 13);
            DateTime dateRichDad = new DateTime(1989, 4, 19);
            DateTime dateSchool = new DateTime(1921, 8, 21);
            DateTime dateBusiness = new DateTime(1900, 8, 21);
            Author robertK = new Author{
                Name = "Robert T.Kiyosaki",
                DateOfBorn = dateRobert
            };
            Author danielK = new Author
            {
                Name = "Daniel Goleman",
                DateOfBorn = dateGoleman
            };
            Author joeD = new Author {
                Name="Joe Dispenza",
                DateOfBorn=dateJoe 
            };

            Author melRobbins = new Author 
            {
                Name="Mel Robbins",
                DateOfBorn=dateMel
            };
            Author markManson = new Author 
            {
                Name= "Mark Manson", DateOfBorn=dateMark
            };
            List<string> categories1 = new List<string>();
            categories1.Add("drama");
            categories1.Add("self-help guide");
            categories1.Add("science-fiction");
            Book subtilArt = new Book
            {
                Title = "The Subtle Art of Not Giving a Fuck: A Counterintuitive Approach to Living a Good Life",
                AuthorofBook = markManson,
                PublishDate = datePublishofArt,
                Categories =categories1
            };
            List<string> categories2 = new List<string>();
            categories2.Add("drama");
            categories2.Add("self-help guide");
            categories2.Add("hope");
            categories2.Add("science-fiction");
            Book EverythingisF = new Book
            {
                Title = "Everythink is fucked",
                AuthorofBook = markManson,
                PublishDate = dateEverythingisf,
                Categories = categories2
            };
            markManson.addBook(subtilArt);
            markManson.addBook(EverythingisF);
            List<string> categories3 = new List<string>();
            categories3.Add("drama");
            categories3.Add("self-help guide");
            categories3.Add("self-help");
            categories3.Add("science-fiction");
            Book fiveSecondsrule = new Book
            {
                Title = "5secondRules",
                AuthorofBook = melRobbins,
                PublishDate = date5secondRules,
                Categories = categories3
            };
            List<string> categories4 = new List<string>();
            categories4.Add("self-help guide");
            Book youAreFine = new Book
            {
                Title = "YouAreFine",
                AuthorofBook = melRobbins,
                PublishDate = dateYouAreFine,
                Categories = categories4
            };
            melRobbins.addBook(youAreFine);
            melRobbins.addBook(fiveSecondsrule);
            List<string> categories5 = new List<string>();
            categories5.Add("self-help guide");
            categories5.Add("spirituality");
            Book trainYourBrain = new Book
            {
                Title = "Train your brain",
                AuthorofBook = joeD,
                PublishDate = dateTrainYourBrain,
                Categories = categories5
            };
            List<string> categories6 = new List<string>();
            categories6.Add("spirituality");
            categories6.Add("science - fiction");
            Book becomingSupernatural = new Book
            {
                Title = "Becoming Supernatural",
                AuthorofBook = joeD,
                PublishDate = dateBecomingSupernatural,
                Categories = categories6
            };
            joeD.addBook(becomingSupernatural);
            joeD.addBook(trainYourBrain);
            List<string> categories7 = new List<string>();
            categories7.Add("financial education");
            Book richDadPoorDad = new Book
            {
                Title = "Rich Dad Poor Dad ",
                AuthorofBook = robertK,
                PublishDate = dateRichDad,
                Categories = categories7
            };
            List<string> categories8 = new List<string>();
            categories8.Add("financial education");
            categories8.Add("science-fiction");
            Book theBusinessSchoolForPeople = new Book
            {
                Title = "The Business School for People",
                AuthorofBook = robertK,
                PublishDate = dateSchool,
                Categories = categories8
            };
            List<string> categories9 = new List<string>();
            categories9.Add("spirituality");
            categories9.Add("financial education");
            categories9.Add("science-fiction");
            Book theBusiness = new Book
            {
                Title = "The Business",
                AuthorofBook = robertK,
                PublishDate = dateBusiness,
                Categories = categories9
            };
            robertK.addBook(richDadPoorDad);
            robertK.addBook(theBusinessSchoolForPeople);
            robertK.addBook(theBusiness);
            List<Book> books = new List<Book>();
            books.Add(subtilArt);
            books.Add(theBusiness);
            books.Add(theBusinessSchoolForPeople);
            books.Add(richDadPoorDad);
            books.Add(becomingSupernatural);
            books.Add(trainYourBrain);
            books.Add(youAreFine);
            books.Add(EverythingisF);
            //books.Add(fiveSecondsrule);

            var library = new Library
            {
                Name = "National Library",
                Address = "123 Main Street, New York",
                Books = books
            };
            Console.WriteLine("Books:");
            foreach (var i in library.Books)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            // 1)add book
            Console.WriteLine("Books, after we added a new book");
            library.addBook(fiveSecondsrule);
            foreach(var i in library.Books)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            // 2) remove a book
            if (library.removeBook(fiveSecondsrule))
            {
                Console.WriteLine("We did it.");
            }
            else
            {
                Console.WriteLine("We don't have that book");
            }
            Console.WriteLine("Books, after we removed a book");
            foreach (var i in library.Books)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            // 3) Get the list of all books
            List<Book> bookss = new List<Book>();
            bookss = library.Books;
            Console.WriteLine("Books:");
            foreach (var i in bookss)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            // 4)Get the list of all books published after 1980
            List<Book> bookss1 = new List<Book>();
            bookss1 = library.GetBooksYear(1980);
            Console.WriteLine("A list of all books published after 1980:");
            foreach (var i in bookss1)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");
            // 5. Get the list of all books with one of the categories: "drama"
            List<Book> bookss2 = new List<Book>();
            bookss2 = library.GetBookscategory("drama");
            Console.WriteLine("A list of all books with one of the categories: drama:");
            foreach (var i in bookss2)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");
            //6.Get the names of all authors that have published at least 3 books
            List<string> authors = new List<string>();
            authors = library.GetAuthors(3);
            Console.WriteLine("A list of names of all authors that have published at least 3 books:");
            foreach (var i in authors)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");
            //7)Get the names of all authors that are born before 1990 and have written at least 2 books of category "science-fiction"
            List<string> authors1 = new List<string>();
            authors1 = library.getAuthorsByNrAndCat(2,1990, "science-fiction");
            Console.WriteLine("A list of names of all authors that are born before 1990 and have written at least 2 books of category science - fiction");
            foreach (var i in authors1)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------");

            //8) Write a method that returns an IGrouping of Books grouped by the decade they were published in.

            IEnumerable<IGrouping<int, Book>> b = library.getBooksGroupedByDecade();
            foreach (var group in b)
            {
                Console.WriteLine($"Decade:{group.Key}");

                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }

        }
    }
}
