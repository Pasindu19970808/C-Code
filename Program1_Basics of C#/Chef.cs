using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    class Chef
    {

        public void chickenChef()
        {
            Console.WriteLine("Making Chicken");
        }

        public void fishChef()
        {
            Console.WriteLine("Making fish");
        }

        public virtual void specialChef()//virtual void means
            //that subclasses can change it 
        {
            Console.WriteLine("Making Special");
        }

    }
}
