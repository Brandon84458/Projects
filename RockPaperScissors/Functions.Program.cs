using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

partial class Program
{
    static string GenerateMove()
    {   
        string input; // either "ROCK", "PAPER", or "SCISSORS"

        // Generate random number in [1,3]
        Random rand = new Random();
        int number = rand.Next(1,4);

        // Uses random number to get CPU input
        input = number switch
        {
            1 => input = "ROCK",
            2 => input = "PAPER",
            3 => input = "SCISSORS",
            _ => input = string.Empty
        };

        return input;
    }

    static bool ValidateInput( string input )
    {
        string inputPlayer;
        bool isValid = false;

        inputPlayer = input.ToUpper();

        isValid = inputPlayer switch
        {
            "ROCK" => isValid = true,
            "PAPER" => isValid = true,
            "SCISSORS" => isValid = true,
            _ => isValid = false
        };

        return isValid;
    }

    static string PlayGame(string inputPlayer, string inputCPU)
    {
        string message = "";

        switch (inputCPU)
        {
            case "ROCK":
                if(inputPlayer == "ROCK")
                {
                    message = "draw";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "player";
                }
                else
                {
                    message = "cpu";
                }
                break;
            case "PAPER":
                if(inputPlayer == "ROCK")
                {
                    message = "cpu";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "draw";
                }
                else
                {
                    message = "player";
                }
                break;
            case "SCISSORS":
                if(inputPlayer == "ROCK")
                {
                    message = "player";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "cpu";
                }
                else
                {
                    message = "draw";
                }
                break;
        }

        return message;
    }

    static string GetPlayerMove()
    {
        string move;

        do
        {
            move = ReadLine(); // reads in players move

            if (!ValidateInput(move))
            {
                Write("Please enter a valid move: ");
            }
        }
        while (!ValidateInput(move));

        return move;
    }

    static void Menu()
    {
        WriteLine(" ----------------------------------- ");
        WriteLine(" | WELCOME TO ROCK, PAPER, SCISSORS | ");
        WriteLine(" ----------------------------------- ");
        WriteLine("Rules:");
        WriteLine("  (1) ROCK > SCISSORS");
        WriteLine("  (2) PAPER > ROCK");
        WriteLine("  (3) SCISSORS > PAPER");
        WriteLine("  (4) BEST OF THREE GAMES");
    }
}