#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string line = System.Console.ReadLine();
        int num = int.Parse(System.Console.ReadLine());
        int result = solution(line, num);
        System.Console.WriteLine($"{result}");
    }
    static int solution(string s, int num)
    {
        int counter = 1;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case ' ':
                    if (counter == num) { return i + 1; } else { counter++; }
                    break;
                default: break;
            }
        }
        return 0;
    }
}