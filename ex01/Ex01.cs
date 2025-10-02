using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool ContainsNegative(IEnumerable<int> numbers)
        {
        //Using foreach
            /*//your code goes here
            foreach(int number in numbers){
                if(number < 0){
                    return true;
            }
            }
          return false;
        }*/
            //Using the Any method from LINQ 
            return numbers.Any(number => number < 0);
    }
}
    
}