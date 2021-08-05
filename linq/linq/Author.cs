using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Author: IEquatable<Author>
    {
        public bool Equals(Author other)
        {
            if (other is null)
                return false;

            return this.Id == other.Id;
        
        }

        public override bool Equals(object obj) => Equals(obj as Author);
        public override int GetHashCode() => (Name, Id).GetHashCode();
 
    public string Name{ set; get;}
        public DateTime DateOfBorn { get; set; }
        public List<Book> Books { get; set; }
        public Guid Id { get; set; }
        public Author(string name, DateTime dateofBorn)
        {
            Id = new Guid();
            Name = name;
            DateOfBorn = dateofBorn;
            Books = new List<Book>();
        }
        public Author()
        {
            Id = new Guid();
            Books = new List<Book>();
        }
        public void addBook(Book book)
        {

            Books.Add(book);

        }

        public Author(string name,DateTime dateofBorn,List<Book>books):this(name,dateofBorn)
        {
            Books = books;
        }
        public override string ToString()
        {
            StringBuilder books = new StringBuilder();
            foreach (var i in Books)
            {

               books.AppendFormat(i.Title);
               books.AppendFormat(" ");
            }
            return $"My name is :{Name}. I was born on: {DateOfBorn}.I wrote: {books}";
        }

        public static implicit operator Author(Guid v)
        {
            throw new NotImplementedException();
        }
    }
}
