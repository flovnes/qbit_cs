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
        int patternIndex = 0;
        for (int start = 0; start <= word.Length - pattern.Length; start++)
        {
            for (int wordIndex = start; wordIndex < pattern.Length + start; wordIndex++)
            {
                System.Console.Write($"{pattern[patternIndex]}");
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
                    return start + 1;
                }
            }
        }
        return 0;
    }
}