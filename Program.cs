// See https://aka.ms/new-console-template for more information


using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Text;
using System.Linq;

class MathGame
{

    static List<String> prevGames = new List<String>();
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
                    Calculate(0);
                    break;
                case "S":
                    Calculate(1);
                    break;
                case "M":
                    Calculate(2);
                    break;
                case "D":
                    Calculate(3);
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
        Console.WriteLine("List of previous games:");

        foreach (var game in prevGames)
        {
            Console.WriteLine(game);
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
        return;
    }

    static void Calculate(int type)
    {
        int score = 0;

        for (int i = 0; i < 5; i++)
        {

            StringBuilder str = new StringBuilder();

            Console.Clear();

            Random rnd = new Random();

            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);

            int answer = 0;

            switch (type)
            {
                case 0:
                    Console.WriteLine("Addition game");
                    answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2);
                    str.Append(num1 + " + " + num2);
                    break;
                case 1:
                    Console.WriteLine("Subtraction game");
                    answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2);
                    str.Append(num1 + " - " + num2);

                    break;
                case 2:
                    Console.WriteLine("Multiplication game");
                    answer = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2);
                    str.Append(num1 + " * " + num2);
                    break;
                case 3:
                    Console.WriteLine("Division game");
                    double ans = ((double) num1) / ((double) num2);
                    while (ans % 1 != 0)
                    {
                        num1 = rnd.Next(1, 10);
                        num2 = rnd.Next(1, 10);
                        ans = ((double) num1) / ((double) num2);
                    }
                    answer = (int)ans;
                    Console.WriteLine(num1 + " / " + num2);
                    str.Append(num1 + " / " + num2);

                    break;
                default:
                    Console.WriteLine("Error, invalid type given.");
                    break;

            }

            String res = Console.ReadLine();

            if (int.TryParse(res, out int response))
            {
                if (answer == response)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    score++;
                }
                else
                {
                    Console.WriteLine("That was incorrect, better luck next time. Type any key for the next question.");

                }

                str.Append("\n Correct response: " + response);
                str.Append("\n Your response: " + answer);
            }
            else
            {
                // Conversion failed, handle the error.
                Console.WriteLine("Invalid response");
            }

            Console.ReadKey();
            Console.Clear();

            prevGames.Add(str.ToString());
        }
        Console.WriteLine("Game over. Your final score was " + score + ". Press any key to go back to the main menu.");
        Console.ReadKey();
        Console.Clear();

        

        return;
    }




}