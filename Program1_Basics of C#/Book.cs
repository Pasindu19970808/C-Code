using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    class Book
    {
        //class is a blueprint for a new data type
        //Class attributes
        //these attributes are unique to the instance that is created
        public string Title;
        public string author;
        public int pages;
        //Static attributes are common for each instance
        public static int BookCount = 0;



        //THIS CONTRUCTOR ALLOW TO DEFINE THE CLASS WITHOUT 
        //PASSING IN THE PARAMETERS
        public Book()
        {

        }


        public Book(string aTitle, string aAuthor, int aPages)
        {
            //THE ATTRIBUTES OF THE BOOK ARE STILL 
            //THE ATTRIBUTES WE DEFINED EARLIER
            Title = aTitle;
            author = aAuthor;
            pages = aPages;
            BookCount++;
        }


        //DEFINING METHODS

        public int pagenumber(int factor)
        {

            //string result;
            //if (pages >= 200)
            //{
            //    result = "Big Book";
            //    return result;
            //}
            //else
            //{
            //    result = "Small Book";
            //    return result;
            //}
            int newpagenum = pages * factor;
            return newpagenum;

        }

        public static int totalbookpages(int page1, int page2)
        {
            return (page1 + page2);


        }



    }



}
