using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_TUR_PÅ_BIBLIOTEKET
{
    class BookList
    {
        private static List<Book> availbleBooks = new List<Book>();

        //adding Books to the list 
        public void AddToList(Book book)
        {
            availbleBooks.Add(book);
        }

        public List<Book> AvailbleBooks
        {
            get { return availbleBooks; }
        }


        //removing from the list
        public void RemoveFromList(Book book)
        {
            book.Count++;
        }
        
    }
}
