#nullable disable
using System.Text;
class Program
{
    (string[] args)
    {
        if (int.TryParse(Console.ReadLine(), out int chars_size))
        {
            string letters = Console.ReadLine();

            if (letters.Length >= chars_size)
            {
                solution(chars_size, letters);
}
            else
{
    Console.WriteLine("not enought chars");
}
        }
        else
{
    Console.WriteLine("?!");
}
    }

    static void solution(int size, string letters)
{
    if (size <= 0 || string.IsNullOrEmpty(letters))
    {
        Console.WriteLine("???");
        return;
    }

    int[] list = new int[256];
    int curmode = 0;

    for (int i = 0; i < size; i++)
    {
        list[(int)letters[i]]++;
        if (list[(int)letters[i]] > list[curmode])
        {
            curmode = (int)letters[i];
        }
        else if (list[(int)letters[i]] == list[curmode])
        {
            curmode = Math.Min((int)letters[i], curmode);
        }
    }
    System.Console.Write($"{curmode}");
}
}