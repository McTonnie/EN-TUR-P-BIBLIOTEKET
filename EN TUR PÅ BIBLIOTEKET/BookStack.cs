using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_TUR_PÅ_BIBLIOTEKET
{
    class BookStack
    {

        private Stack<Book> bookInStack = new Stack<Book>();


        public Stack<Book> BookInStack 
        {
            get { return bookInStack; }
        }

        public BookStack() { }


        
        public void Addbook(Book book)
        {
            bookInStack.Push(book);
        }
        public void Remove()
        {
            bookInStack.Pop();
        }
        public bool CheckNext()
        {

            try
            {


                bookInStack.Peek();
                return true;
            }
            catch (Exception)
            {
    
            return false;
                
            }


        }
    }
}
