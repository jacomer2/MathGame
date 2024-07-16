// See https://aka.ms/new-console-template for more information


using System.Numerics;

class MathGame
{
    static void Main(String[] args)
    {

        bool quit = false;

        while(!quit)
        {
            Console.WriteLine("What game would you like to play today? Choose from the options below:");
            Console.WriteLine("V - View Previous Games");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - Quit the program");
            Console.WriteLine("----------------------------------------------");

            String res = Console.ReadLine();

            // if response is null, set to blank line
            res ??= "";

            switch (res.ToUpper())
            {
                case "V":
                    PreviousGames();
                    break;
                case "A":
                    Addition();
                    break;
                case "S":
                    Subtraction();
                    break;
                case "M":
                    Multiplication();
                    break;
                case "D":
                    Division();
                    break;
                case "Q":
                    return;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

            }

            if (res != null && res.ToUpper().Equals("Q"))
            {
                return;
            }
        }

    }

    static void PreviousGames()
    {
        Console.WriteLine("In previous games");
        return;
    }

    static void Addition()
    {
        Console.WriteLine("In addition");
        return;
    }

    static void Subtraction()
    {
        Console.WriteLine("In subtraction");
        return;
    }

    static void Multiplication()
    {
        Console.WriteLine("In multiplication");
        return;
    }

    static void Division()
    {
        Console.WriteLine("In division");
        return;
    }

}