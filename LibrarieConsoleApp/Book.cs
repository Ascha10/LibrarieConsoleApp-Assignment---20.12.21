using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieConsoleApp
{
     class Book
    {
        public string name;
        public string author;
        public int numberOfPages;

        public Book(string name, string author, int numberOfPages)
        {
            this.name = name;
            this.author = author;
            this.numberOfPages = numberOfPages;
        }
    }
}
