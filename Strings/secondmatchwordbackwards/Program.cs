#nullable disable
using System;
class Program
{
    static void Main(string[] args)
    {
        string search = System.Console.ReadLine();
        string line = System.Console.ReadLine();
        System.Console.WriteLine($"\n{solution(line, search)}");
    }
    static int solution(string word, string pattern)
    {
        int patternIndex = pattern.Length - 1, counter = 0;
        bool f = false;
        for (int start = 0; start < word.Length - pattern.Length; start++)
        {
            for (int wordIndex = start + pattern.Length - 1; wordIndex >= start; wordIndex--)
            {
                counter++;
                if (pattern[patternIndex] == word[wordIndex])
                {
                    patternIndex--;
                }
                else
                {
                    patternIndex = pattern.Length - 1;
                    break;
                }
                if (patternIndex == 0)
                {
                    patternIndex = 0;
                    f = true;
                    System.Console.Write($"{start + 1} ");
                }
            }
        }
        if (!f) { System.Console.Write($"0"); }
        return counter;
    }
}