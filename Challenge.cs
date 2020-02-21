using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2b
{
    class Challenge
    {
        static void CreateArray (string message)
        {
            string phrase = "The quick brown    fox     jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

        }

       
    }
}
