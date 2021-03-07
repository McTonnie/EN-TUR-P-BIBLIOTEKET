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


        //this is the number of this book at the libirry
        private int count;

        public int Count
        {
            
            get { return count; }
            set { count = value; }
        }

        public Book() { }

        public Book(string name, string auther, int releasedate, int count) 
        {
            this.name = name;
            this.auther = auther;
            this.releasedate = releasedate;
            this.count = count;

        }




        public void AddCount(Book book)
        {
            book.count++;
        }




    }
}
