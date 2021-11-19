using System;

namespace Properties
{
    // classes have a name, unique within the namespace
    class Book
    {
        // classes have instance variables to hold data
        private string _name;
        private string _author;
        private int _pagecount;

        // classes have one or more constructors
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // TODO: use Properties to implement access to our internal data
        // This is called a Property with a "backing field"


        // TODO: There's a shorthand way of writing these using the => operator
        // to create "expression-bodied" properties


        // TODO: You can omit the get or set if you want to prevent
        // modification or reading the value, or if you want to create
        // a "computed property" from other fields


        // TODO: Properties can be auto-generated - if there's no
        // backing field, the property can hold the data

    }
}
