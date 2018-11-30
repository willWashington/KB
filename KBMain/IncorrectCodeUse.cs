using System;
using System.Collections.Generic;
using System.Text;

namespace KBMain
{
    class IncorrectCodeUse
    {
        internal void DateTest() //internal makes the method available to the entire class, replacing the default of private without using the
                                 //public keyword and exposing it to the world
        {
            //INCORRECT
            DateTime date = new DateTime(2002, 8, 11);
            date.AddDays(1);
                //this code is incorrect because the date variable is immutable, meaning it cannot be changed once instantiated.
                //.AddDays is a method that returns a new variable that is an edited copy of the date variable we created.
                //we have essentially lost the original variable if we use this process

            //CORRECT
            DateTime date1 = new DateTime(2002, 8, 11);
            date1 = date1.AddDays(1);
                //this syntax will declare the original variable equal to the new variable that is generated on the back end,
                //thereby maintaining our original variable, and accurately adding one day to the date.
        }

        void StringTest()
        {
            //INCORRECT
            string name = "Scott";
            name.Trim();
                //this code is incorrect for the same reason as before. String is a reference type, not a value type, because it stores
                //a number of chars in an array, rather than holding an actual value. It works the same way as above, though, such that when we
                //call Trim(), it is creating a new variable on the back end, modifying it, and giving it back to us. We have lost our original 
                //data at this point.

            //CORRECT
            string name1 = "Scott";
            name1 = name.Trim();
                //the same is true here because .Trim() is returning a variable.
                //if we test these variables against the original, we get errors because name.Trim() is not the same as name            
        }
    }
}
