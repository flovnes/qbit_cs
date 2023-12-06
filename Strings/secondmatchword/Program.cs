#nullable disable
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
        int patternIndex = 0, counter = 0;
        bool f = false;
        for (int start = 0; start <= word.Length - pattern.Length; start++)
        {
            for (int wordIndex = start; wordIndex < pattern.Length + start; wordIndex++)
            {
                counter++;
                if (pattern[patternIndex] == word[wordIndex])
                {
                    patternIndex++;
                }
                else
                {
                    patternIndex = 0;
                    break;
                }
                if (patternIndex > pattern.Length - 1)
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