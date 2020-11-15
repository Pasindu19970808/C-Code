using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    class Italianchef : Chef //Inherits all the attributes and methods of the superclass
    {
        public void makepasta()
        {
            Console.WriteLine("Make Pasta");

        }

        public override void specialChef()
            //override means that the method can be overwritten
        {
            Console.WriteLine("Making Pizza");
        }
    }
}
