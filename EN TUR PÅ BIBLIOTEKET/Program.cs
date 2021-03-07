using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EN_TUR_PÅ_BIBLIOTEKET
{
    class Program
    {
        static BookStack bookStack = new BookStack();
        static BookList bookList = new BookList();
        List<Book> userborrows = new List<Book>();
        static void Main(string[] args)
        {

            Book harryPotter1 = new Book("Harry Potter og de vises sten", "JK Rowling " , 1997, 1);
            bookList.AddToList(harryPotter1);
            Book percyJackson1 = new Book("Percy Jacson og lyntyven", "Rick riodan " ,2005, 9);
            bookList.AddToList(percyJackson1);
            Book ternetNinja1 = new Book("Ternet Ninja", "Anders Mattensen" , 2016, 10);
            bookList.AddToList(ternetNinja1);
            Book ternetNinja2 = new Book("Ternet Ninja 2", "Anders mattensen" , 2019, 10);
            bookList.AddToList(ternetNinja2);
            showBooksAndSelect();

            Console.WriteLine("Press any key to proceed to borrowing the books");
            Console.ReadKey();
            Console.WriteLine("Plz wait while th esystem registers your borrows");
            Registerborrows();
        }





        public static void showBooksAndSelect()
        {
            bool repeat = false;
            do
            {

            Console.Clear();
            //printing out the bokks and the number of it 
            Console.WriteLine("Find books you want to borrow");
            Console.WriteLine();
            for (int i = 0; i < bookList.AvailbleBooks.Count(); i++)
            {
                    // the + 1 is so the user dont have tp press 0 (only for showcase)
                Console.WriteLine((i + 1) + ") " + bookList.AvailbleBooks[i].Name + "    Left in stock " + bookList.AvailbleBooks[i].LeftInStock);
            }

                
                Console.WriteLine();
                Console.WriteLine("What book do you want to add");
                int userchoise = Convert.ToInt32(Console.ReadLine()) - 1;
                if (bookList.AvailbleBooks[userchoise].LeftInStock > 0)
                {
                    bookStack.Addbook(bookList.AvailbleBooks[userchoise]);
                    bookList.RemoveFromList(bookList.AvailbleBooks[userchoise]);
                    
                }
                else
                {
                    Console.WriteLine("The book is not available at the time");
                }




                Console.WriteLine("Do you want to borrow more books");
                Console.WriteLine("type Y or N");
                if (Console.ReadLine().ToString() == "Y".ToLower())
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }

            } while (repeat);

        }
        public static void Registerborrows()
        {
            while (bookStack.CheckNext())
            {
                Console.WriteLine(bookStack.BookInStack.Peek().Name + " Registered");
                bookStack.BookInStack.Pop();
                Thread.Sleep(2000);

            }
            Console.WriteLine("All your bokks are now registered yuo can go now");
            Console.ReadKey();
        }


    }
}
