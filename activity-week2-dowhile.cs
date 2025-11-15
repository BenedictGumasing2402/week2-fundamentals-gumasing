using System;

public class Program
{
    public static void Main()
    {
        int j = 0;
        do
        {
            if (j % 2 == 0)
            {
                Console.WriteLine(j);
            }
        }

        while (j < 20);
    }
}