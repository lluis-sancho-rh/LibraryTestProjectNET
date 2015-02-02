using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
   public class Author
    {

        public int AuthorID { get; set; }

        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
