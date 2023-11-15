using System;

class Program
{
    static void Main()
    {
        Solution();
    }
    static void Solution()
    {
        byte num = byte.Parse(Console.ReadLine());

        for (int line = 1; line <= num * 2 - 1; line++)
        {
            if (line <= num)
            {
                for (int i = 1; i <= num; i++)
                {
                    bool firstStar = true;
                    if (i > num - line) {
                        if (i == num)
                        {
                            Console.Write("*");
                        }
                        else if (i == num - line + 1)
                        {
                            if (firstStar == true) {
                                if (line == 1) {
                                    Console.Write("*".PadLeft(num*2));
                                } else {
                                Console.Write("* ".PadLeft(num*2));
                                firstStar = false;
                            }
                        }
                    }
                    else
                    { Console.Write("+ ");}

                    }
                }
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    bool firstStar = true;
                    if (i > line - num)
                    {
                        if (i == num)
                        {
                            Console.Write("*");
                        }
                        else if (i == line - num + 1)
                        {
                            if (firstStar == true) {
                                if (line == num*2-1) {
                                    Console.Write("*".PadLeft(num*2));
                                } else {
                                Console.Write("* ".PadLeft(num*2));
                                firstStar = false;
                            }
                        }
                        else
                        {
                            Console.Write("+ ");
                        }
                        }
                    }
                }
            Console.WriteLine();
            }
        }
    }
}