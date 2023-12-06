#nullable disable
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int chars_size = int.Parse(System.Console.ReadLine());
        string letters = System.Console.ReadLine();
        solution(chars_size, letters);
    }
    static void solution(int size, string letters)
    {
        for (int i = 0; i < size; i++)
        {
            System.Console.Write($"{(int)letters[i]} ");
        }
    }
}