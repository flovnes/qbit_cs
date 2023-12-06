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
        string result = cutOut(line, a, b);
        System.Console.WriteLine($"{result}");
    }
    static string cutOut(string s, int start, int end)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (i < start || i > end)
            {
                result.Append(s[i]);
            }
        }
        return result.ToString();
    }
}