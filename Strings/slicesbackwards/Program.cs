#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string line = System.Console.ReadLine();
        string[] data = System.Console.ReadLine().Trim().Split();
        int a = int.Parse(data[0]) - 1;
        int b = int.Parse(data[1]) - 1;
        System.Console.WriteLine($"{System.Math.Max(0, b - a + 2)}");
        solution(line, a, b);
    }
    static void solution(string s, int start, int end)
    {
        while (start < end)
        {
            StringBuilder result = new StringBuilder();
            for (int i = start + 1; i <= end; i++)
            {
                result.Append(s[i]);
            }
            System.Console.WriteLine($"{result}");
            start++;
        }
    }
}