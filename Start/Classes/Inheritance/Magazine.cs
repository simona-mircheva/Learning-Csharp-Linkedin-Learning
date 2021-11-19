using System;

namespace Inheritance
{
    // TODO: Declare "Magazine" as a subclass of Publication
    class Magazine {
        private string _publisher;
        private int _pagecount;
        private decimal _price;

        // TODO: use the base() keyword to initialize the base class
        public Magazine(string name, string publisher, int pagecount, decimal price) {
            _publisher = publisher;
        }

        public string Publisher {
            get => _publisher;
            set => _publisher = value;
        }
    }
}
