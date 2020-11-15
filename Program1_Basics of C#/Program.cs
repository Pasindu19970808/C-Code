using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Bob SS";

            char grade = 'A';
            int Age = 30;
            double gpa = 3.931;

            Age = 23;
            //prints both A and B with the " in middle
            Console.WriteLine("A\"B");
            int lenofstring;
            lenofstring = Name.Length;

            //create as an array and covert to list
            string[] wordlist = Name.Split(" ");
            List<string> seplist = new List<string>();
            seplist = wordlist.ToList();

            /////
            //foreach (string word in wordlist)
            //{
            //    Console.WriteLine(word);
            //}

            //foreach (string word in wordlist)
            //{
            //    seplist.Add(word);
            //};
            //int leng = seplist.Count;
            //Console.WriteLine(wordlist[0..leng]);

            Console.WriteLine(seplist.Contains("Bob"));

            string Town = "Tsim Sha Tsui";

            //Joining a list together
            string[] list2 = Town.Split(" ");
            List<string> seplist2 = list2.ToList();

            Console.WriteLine(String.Join("", seplist2));


            //Console.WriteLine(Town.Substring(3, 9));
            //Console.WriteLine(Town.IndexOf("Sha"));


            //Console.Write("Enter:");

            ////stores as a string

            //string data = Console.ReadLine();
            //Console.WriteLine(data);
            ////converting strings to a int/double

            //double num = Convert.ToDouble(data);
            //Console.WriteLine(Math.Sin(num));
            //string data2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(data2);
            //Console.WriteLine(num * num2);

            //Console.ReadLine();

            //arrays
            //shows that this variable is a list

            //ARRAYS
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            //comment: Arrays are mutable
            numbers[1] = 900;
            //if we dont give the elements in the array, we must give
            //the number of elements it can hold
            string[] words = new string[5];
            words[0] = "AA";
            words[1] = "AB";

            Console.WriteLine(words[1]);

            SayHi(90);
            SayHi(Math.PI);

            Console.WriteLine(poly(5));

            //declares a new list
            List<int> num_list = new List<int>() { 2, 3, 4, 5, 6 };
            List<int> res_list = new List<int>();
            //num_list = [2, 3, 4, 5, 6];
            double coef1 = 1;
            double coef2 = 1;

            res_list = poly_array(num_list, coef1, coef2);

            foreach (int res in res_list)
            {
                Console.WriteLine(res);

            }

            //IF STATEMENTS

            bool isMale = true;
            bool isTall = true;
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else if (isMale && !isTall) //!isTall reads as is not Tall
            {
                Console.WriteLine("ABC");
            }
            else
            {
                Console.WriteLine("You are not male");
            }

            //SWITCH STATEMENT
            string day;
            day = GetDay(5);
            Console.WriteLine(day);

            //WHILE LOOPS
            int index = 1;

            while (index <= 5) 
            {
                Console.WriteLine(index);
                index++;
            }

            //DO WHILE LOOP
            //In a do while loop, the code first executes and checks the
            //while condition
            int index_num = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index_num <= 5);

            //FOR LOOP
            List<string> strlist = new List<string> { "AA", "BB", "CC" };
            for(int i = 1; i<= strlist.Count;i++)
            {
                Console.WriteLine(strlist[i-1]); 
            }

            //2D arrays
            int[,] numberGrid = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //Getting number of rows and columns of array
            int numofrows = numberGrid.GetLength(0);
            int numofcols = numberGrid.GetLength(1);

            for (int i = 0; i < numofrows; i++)
            { 
                for (int j = 0;j < numofcols; j++) 
                {

                    Console.WriteLine(numberGrid[i, j]);
                
                }
            
            
            }

            //Exception handling
            try
            {
                Console.WriteLine("Enter Num1:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Num2");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message + "HAHA");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //CLASSES
            //Creating instance of a class

            Book book1 = new Book("ANC","ABG",400);
            //setting attributes of the Book
            //book1.Title = "ANC";
            //book1.author = "ABG";
            //book1.pages = 400;

            Book book2 = new Book("HHH","LLL",300);
            //book2.Title = "HHH";
            //book2.author = "LLL";
            //book2.pages = 300;

            //CONSTRUCTORS
            //A special method we can put inside the class
            int newnum = book2.pagenumber(3);
            Console.WriteLine(newnum);


            //GETTERS SETTERS
            //used to restrict access to attributes
            Movie movie1 = new Movie("AR", "TT", "TT");
            Movie movie2 = new Movie("AE", "TE", "TT");
            //movie1.rating;
            //Gives "Inaccessible due to protection level
            Console.WriteLine(movie1.Rating);
            movie1.Rating = "TT";
            Console.WriteLine(movie1.Rating);

            //STATIC ATTRIBUTES
            //Static attributes are shared by the class itself 
            //hence shared by all the instances of that class
            //not just one instance
            //The attribute is shared with all instances
            Console.WriteLine(Book.BookCount);
            //it prints 2 although in the class we defined it as 
            //zero because we are creating 2 books earlier. 
            //each instance created increases count by 1

            //STATIC METHODS
            //A Function that belongs to the entire class
            //not any instance only
            Console.WriteLine(Book.totalbookpages(book1.pages, book2.pages));

             //INHERITANCE
             Italianchef chef1 = new Italianchef();
             chef1.makepasta();
             Chef chef2 = new Chef();
             chef2.chickenChef();
             chef1.specialChef();
              chef2.specialChef();


           
        }
        //METHODS
        // void means it returns nothing 
        static void SayHi(double num)
        {
            int result = Convert.ToInt32(Math.Sin(num));

            Console.WriteLine(result);

        }

        //METHOD WHICH RETURNS SOMETHING of a particular datatype
        static int poly(double num)
        {
            double val = 1 + num + Math.Pow(num, 2);
            return Convert.ToInt32(val);


        }

        //pply polynomial function to entire list of numbers
        static List<int> poly_array(List<int> num_list, double coef1, double coef2)
        {
            //int len = num_array.Length;
            List<int> result = new List<int>();

            foreach (double num in num_list)
            {
                result.Add(Convert.ToInt32(1 + coef1 * num + coef2 * Math.Pow(num, 2)));



            }

            return result;

        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;

        }
        // SWITCH STATEMENT
        static string GetDay(int dayNum)
        {
            string dayName;
            List<int> daynumlist = new List<int> { 0, 1, 2, 3 };

            if (daynumlist.Contains(dayNum))
            {
                switch (dayNum)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    default:
                        dayName = "Not Set lol";
                        break;
                }
                return dayName;
            }
            else
            {

                //Console.WriteLine("Day Number is Out of Range");
                dayName = "Not Set";
                return dayName;
            }

            static double GetPow(double num1, double num2) 
            {
                double result = 1;

                for(double i = 0; i<num2; i++) 
                {
                    result = result * num2;
                
                }
                return result;
            
            }

        }
    }
}
