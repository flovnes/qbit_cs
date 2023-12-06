#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string line = System.Console.ReadLine();
        string result = doublez(line);
        System.Console.WriteLine($"{result}");
    }
    static string doublez(string s)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'z': result.Append("zz"); break;
                default: result.Append(s[i]); break;
            }
        }
        return result.ToString();
    }
}