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
        int counter = 0;
        string result = cutOut(line, a, b, ref counter);
        System.Console.WriteLine($"{counter}");
        System.Console.WriteLine($"{result}");
    }
    static string cutOut(string s, int start, int end, ref int counter)
    {
        StringBuilder result = new StringBuilder();
        for (int i = start; i <= end; i++)
        {
            result.Append(s[i]);
            counter++;
        }
        return result.ToString();
    }
}