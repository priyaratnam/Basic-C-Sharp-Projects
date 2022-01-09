using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment_Part_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score:" + testScores[i]);
                }
            }
            Console.ReadLine();

            string[] names = { "Priya", "Ratnam", "Mala", "Chelvi" };
            for (int j = 0; j < names.Length; j++)
            {
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();

        }
    }
}
        internal class Program1
        {
            static void Mains(string[] args)
            {
                List<int> testScores = new List<int>();
        testScores.Add(98);
        testScores.Add(99);
        testScores.Add(81);
        testScores.Add(72);
        testScores.Add(70);

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score:" + score);
            }
        }
        Console.ReadLine();
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() { "Priya", "Ratnam", "Mala", "Chelvi" };
        foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        Console.ReadLine();
    }
}
internal class Program3
{
    static void Main(string[] args)
    {
        List<int> testScore = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScore)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
}
