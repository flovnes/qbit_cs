#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string a = System.Console.ReadLine();
        string b = System.Console.ReadLine();
        solution(System.Convert.ToInt32(a[0]), System.Convert.ToInt32(b[0]));
    }
    static void solution(int start, int end)
    {
        if (start > end) { int t = start; start = end; end = t; }
        for (int i = start; i <= end; i++)
        {
            System.Console.Write($"{System.Convert.ToChar(i - 32)}{System.Convert.ToChar(i)} ");
        }
    }
}