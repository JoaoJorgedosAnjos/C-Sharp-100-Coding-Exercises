using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static (string firstName, string lastName) SplitFullName(string fullName)
        {
            //your code goes here
           var names = fullName.Split(" ");
           return (firstName : names[0], lastName : names[1]);
        }
    }
}