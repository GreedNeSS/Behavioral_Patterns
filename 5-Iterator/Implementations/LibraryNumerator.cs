using _5_Iterator.Interfaces;
using _5_Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Iterator.Implementations
{
    public class LibraryNumerator : IBookIterator
    {
        private IBookNumerable aggregate;
        private int index = 0;

        public LibraryNumerator(IBookNumerable aggregate)
        {
            this.aggregate = aggregate;
        }

        public bool HAsNext()
        {
            return aggregate.Count > index;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }
}
