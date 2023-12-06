#nullable disable
class Program
{
    static void Main(string[] args)
    {
        string search = System.Console.ReadLine();
        string line = System.Console.ReadLine();
        int start = int.Parse(System.Console.ReadLine()) - 1;
        int counter = 1;
        if (solution(line, search, start, ref counter))
        {
            System.Console.WriteLine("YES");
        }
        else
        {
            System.Console.WriteLine("NO");
        }
        System.Console.WriteLine($"{counter}");
    }
    static bool solution(string word, string pattern, int start, ref int counter)
    {
        for (int i = start; i - start < pattern.Length; i++)
        {
            counter = i + 1 - start;
            if (pattern[i - start] != word[i])
            {
                return false;
            }
            if (i - start >= pattern.Length - 1)
            {
                return true;
            }
        }
        return false;
    }
}