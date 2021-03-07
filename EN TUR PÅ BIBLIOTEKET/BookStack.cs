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

        //calling this will return th eprivate Stack bookInStack
        public Stack<Book> BookInStack 
        {
            get { return bookInStack; }
        }

        public BookStack() { }


        //adding a book
        public void Addbook(Book book)
        {
            bookInStack.Push(book);
        }
        public void Remove()
        {
            bookInStack.Pop();
        }

        //this is basicly for checking if there is anything ledt in the stack wantes to try something new
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
