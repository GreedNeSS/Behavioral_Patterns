using _5_Iterator.Interfaces;
using _5_Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Iterator.Implementations
{
    public class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book{ Name = "Война и мир" },
                new Book{ Name = "Приступление и наказание" },
                new Book{ Name = "Отцы и дети" },
            };
        }

        public Book this[int index] => books[index];

        public int Count => books.Length;

        public IBookIterator CreateNumerable()
        {
            return new LibraryNumerator(this);
        }
    }
}
