using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Library.Models
{
   public class Author
    {
       public Author()
       {
           this.Books = new HashSet<Book>();
       }

        public int AuthorID { get; set; }

        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public void BuildBooks(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                Books.Add(new Book());
            }
        }

    }
}
