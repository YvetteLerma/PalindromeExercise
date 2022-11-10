using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string values)
        {
            //string Reversed = "";

            //for (int i = values.Length - 1; i >= 0; i--) 
            //{
            //    Reversed += values[i];
            //}
            //if (Reversed == values)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return values?.ToLower().SequenceEqual(values?.ToLower().Reverse()) ?? false;
        }
    }
}

