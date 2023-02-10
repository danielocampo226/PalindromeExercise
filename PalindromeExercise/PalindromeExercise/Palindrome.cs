using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Palindrome
    {
       public bool IsAPalidrome(string word)
        {
            //reverse the word    //racecar Length --> 7 --> 6
            //var reversed = "";

            //for (int i = word.Length -1; i >= 0; i--)
            //{
            //   reversed += word[i]; 
            //}

            //if (reversed.ToLower() == word.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return word.SequenceEqual(word.Reverse());


        
       }

    }
}
