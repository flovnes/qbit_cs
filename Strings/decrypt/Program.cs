#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int chars_size = int.Parse(System.Console.ReadLine());
        string[] letters = System.Console.ReadLine().Trim().Split();
        solution(chars_size, letters);
    }
    static void solution(int size, string[] letters)
    {
        for (int i = 0; i < size; i++)
        {
            System.Console.Write($"{System.Convert.ToChar(int.Parse(letters[i]))}");
        }
    }
}