using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray = { "One", "dimensional", "array", "of", "strings" };
            Console.WriteLine("Please input a less count of word please?: ");
            string userText = Console.ReadLine();
            for (int i = 0; i < myStringArray.Length; i++)
            {
                string addUserString = myStringArray[i] + " " + userText;
                Console.WriteLine(addUserString + " " + "\n");
            }
            Console.ReadLine();
            string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            for (int j = 0; j < infinite.Length; j++)
            {
                Console.WriteLine(infinite[j]);
            }
            Console.ReadLine();
            int[] myLoop = { 1, 2, 3, 4, 5 };
            for (int k = 0; k < myLoop.Length; k++)
            {
                Console.WriteLine(myLoop[k]);
            }
            Console.ReadLine();
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine(myLoop[l]);
            }
            Console.ReadLine();
            List<string> myWords = new List<string>();
            myWords.Add("My");
            myWords.Add("strength");
            myWords.Add("is");
            myWords.Add("my");
            myWords.Add("dad");
            myWords.Add("and");
            myWords.Add("my");
            myWords.Add("dad");
            myWords.Add("lovable");
            myWords.Add("memories.");
            Console.WriteLine("Connect my words with sentence \"The only true is words are true.\"");
            string userWord = Console.ReadLine();
            foreach (string word in myWords)
            {
                if (word == userWord)
                {
                    Console.WriteLine("The index of " + "\"" + userWord + "\"" + " is: " + myWords.IndexOf(word));
                    break;
                }
            }
            if (myWords.Contains(userWord) == false)
            {
                Console.WriteLine("You must have to enter the letter or word from the sentence.");
            }
            Console.ReadLine();
            List<string> mySong = new List<string>();
            List<int> repeatLyrics = new List<int>();
            mySong.Add("Don't");
            mySong.Add("Beleive");
            mySong.Add("everyone");
            mySong.Add("but");
            mySong.Add("beleive");
            mySong.Add("your");
            mySong.Add("self");
            mySong.Add("thoughts");

            Console.WriteLine("You must have to type the word from the passage: ");
            Console.WriteLine("Don't beleive everyone but beleive your self thoughts");
            string userWordLyric = Console.ReadLine();
            for (int i = 0; i < mySong.Count; i++)
            {
                bool songFound = false;
                if (userWordLyric == mySong[i])
                {
                    songFound = true;
                    Console.WriteLine("The total of the passage: " + i);
                }
            }
            if (mySong.Contains(userWordLyric) == false)
            {
                Console.WriteLine("You must have to type the word from the passage:");
            }
            Console.ReadLine();
            List<string> nameList = new List<string>();
            List<string> nameRepeat = new List<string>();
            nameList.Add("Priya");
            nameList.Add("Abishan");
            nameList.Add("Trishana");
            nameList.Add("Thuva");
            nameList.Add("Abishna");
            nameList.Add("Karan");
            foreach (string name in nameList)
            {
                if (nameRepeat.Contains(name))
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("You enterd name " + name + " has already listed in the coloum!");
                }
                else
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("This is " + name + " not in the list yet!");
                }
            }
            Console.ReadLine();
        }
    }
}