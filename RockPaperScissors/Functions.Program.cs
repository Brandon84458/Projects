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
                    message = "DRAW!";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "PLAYER WINS!";
                }
                else
                {
                    message = "CPU WINS!";
                }
                break;
            case "PAPER":
                if(inputPlayer == "ROCK")
                {
                    message = "CPU WINS!";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "DRAW!";
                }
                else
                {
                    message = "PLAYER WINS!";
                }
                break;
            case "SCISSORS":
                if(inputPlayer == "ROCK")
                {
                    message = "PLAYER WINS!";
                }
                else if (inputPlayer == "PAPER")
                {
                    message = "CPU WINS!";
                }
                else
                {
                    message = "DRAW!";
                }
                break;
        }

        return message;
    }
}