using _5_Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Iterator.Interfaces
{
    public interface IBookIterator
    {
        bool HAsNext();
        Book Next();
    }
}
