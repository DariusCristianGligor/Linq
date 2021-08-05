using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Book: IEquatable<Book >
    {
        public bool Equals(Book other)
    {
        if (other is null)
            return false;

        return ((this.Title==other.Title)&&(this.AuthorofBook==other.AuthorofBook));

    }

    public override bool Equals(object obj) => Equals(obj as Author);
    public override int GetHashCode() => (Title, Id).GetHashCode();
    
        public string Title { set; get; }
        public DateTime PublishDate { get; set; }
        public Guid Id { get; }
        public List<string> Categories { set; get;}
        public Author AuthorofBook { get; set; }
        public Book(string title,DateTime publishDate,Author authorofBook,List<string>categories)
        {

            Title = title;
            PublishDate = publishDate;
            AuthorofBook = authorofBook;
            Categories = categories;
            Id = new Guid();
        
        }
        public Book()
        {
            Id = new Guid();
        }
        public override string ToString()
        {
            StringBuilder cat= new StringBuilder();
            foreach (var i in Categories)
            {
                
                cat.AppendFormat(i);
                cat.AppendFormat(",");
            }
            
            return $@"Title: {Title} ;
Author: {AuthorofBook.Name} ;
PublishDate: {PublishDate} ;
Categories:{cat};
";
        }

    }
}
