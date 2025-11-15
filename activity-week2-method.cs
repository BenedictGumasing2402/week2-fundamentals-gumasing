using System;

public class Program
{
    public static string typeString;

    public static void Main()
    {
        Console.WriteLine("Please enter the word passed: ");
        typeString = Console.ReadLine();
        stringCheck(typeString);
    }

    public static void stringCheck(string encryption)
    {
        if (typeString.ToLower() == "passed")
        {
            Console.WriteLine("encyrpted");
        }

        else
        {
            Console.WriteLine("unenecrypted");
        }
    }
}