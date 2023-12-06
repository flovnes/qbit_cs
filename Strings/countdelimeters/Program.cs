#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string line = System.Console.ReadLine();
        int result = solution(line);
        System.Console.WriteLine($"{result}");
    }
    static int solution(string s)
    {
        int counter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '.':
                case ',':
                case '!':
                case ':':
                case ';': counter++; break;
                default: break;
            }
        }
        return counter;
    }
}