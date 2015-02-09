using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing the required text
            Console.WriteLine(Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!"));
            Console.WriteLine(Disemvoweler("How many bears could Bear Grylls grill if Bear Grylls could grill bears?"));
            Console.WriteLine(Disemvoweler("I'm a code ninja, baby. I make functions and I make calls."));

            // Bonus sentence... there are no vowels!! // Translation: twin gypsys fly slyly and spy a lynx 
            Console.WriteLine(Disemvoweler("Twyndyllyng gypsys fly slyly spy lynx."));
            // keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Takes input, removes the vowels, and returns it and the removed vowels
        /// </summary>
        /// <param name="input">input a soon to be disemvoweled string</param>
        /// <returns>the original, the disemvoweled and the vowels removed</returns>
        public static string Disemvoweler(string input)
        {
            //Create some strings to hold some future info
            string vowelOutput = string.Empty;
            string output = string.Empty;
            //Loop through each character in string
            for (int i = 0; i < input.Length; i++)
            {
                //holds a lowered indexed input character
                string aSingleLetter = input[i].ToString().ToLower();

                //vowel check
                if ("aeiou".Contains(aSingleLetter))
                {
                    //Add to the vowel list
                    vowelOutput += aSingleLetter;
                }
                //spaces are nothing, and to pass some tests so are a few special characters
                else if (aSingleLetter == " " || ".,'?!".Contains(aSingleLetter))
                {

                }
                else
                {
                   //anything else gets added to output because its a constantant
                    output += aSingleLetter;
                }
            }
            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + output);
            Console.WriteLine("Vowels Removed: " + vowelOutput + "::"); 
            // Return the Disemvoweled string as well for testing
            return output;
        }
    }
}
