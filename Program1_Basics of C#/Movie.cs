using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    class Movie
    {
        public string title;
        public string director;
        //only code within the Movie class can access the rating
        //hence it cannot be changed from outside
        private string rating;

        //Define constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            //NOW WHEN WE SET THE RATING IT SETS THE RATING BY PASSING IT
            //THROUGH THE RATING METHOD
            Rating = aRating;
        }

        //we defined rating as a private variable however
        //we require to set this rating within a certain 
        //set of values

        public string Rating
        {
            get { return rating; } //allows viewing of the variable
            set //sets the variable to what you need
            { 
                if(value == "G" || value == "PG")
                    //if the rating is set to a value in this condition
                    //it will be set
                    //else it is 'NR'
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            
            }
        }
             


    }
}
