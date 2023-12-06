#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string line = System.Console.ReadLine();
        string result = swapzv(line);
        System.Console.WriteLine($"{result}");
    }
    static string swapzv(string s)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'z': result.Append('w'); break;
                case 'w': result.Append('z'); break;
                default: result.Append(s[i]); break;
            }
        }
        return result.ToString();
    }
}