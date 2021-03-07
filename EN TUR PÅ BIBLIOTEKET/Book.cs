using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_TUR_PÅ_BIBLIOTEKET
{
    class Book
    {


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string auther;

        public string Auther
        {
            get { return auther; }
            set { auther = value; }
        }




        private int releasedate;

        public int Releasedate
        {
            get { return releasedate; }
            set { releasedate = value; }
        }


        //this is the number of this book at the libirry so the book will never be removed from a list but removed in count
        private int leftInStock;

        public int LeftInStock
        {
            
            get { return leftInStock; }
            set { leftInStock = value; }
        }

        //this is the default construktor
        public Book() { }


        //this is the construktor
        public Book(string name, string auther, int releasedate, int count) 
        {
            this.name = name;
            this.auther = auther;
            this.releasedate = releasedate;
            this.leftInStock = count;

        }




        public void AddCount(Book book)
        {
            book.leftInStock++;
        }




    }
}
