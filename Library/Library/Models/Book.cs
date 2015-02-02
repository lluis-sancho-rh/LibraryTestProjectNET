using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {

        public int BookID { get; set; }

        public string Title { get; set; }

        public int NumPages { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public double Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}