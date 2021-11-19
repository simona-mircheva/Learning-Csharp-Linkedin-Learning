using System;

namespace Inheritance
{
    // TODO: Declare "Book" as a subclass of Publication
    class Book {
        private string _author;
        private int _pagecount;
        private decimal _price;

        // use the base() keyword to initialize the base class
        public Book(string name, string author, int pagecount, decimal price) {
            _author = author;
        }

        public string Author {
            get => _author;
            set => _author = value;
        }
        
        // TODO: use the override keyword to override a base class method

    }
}