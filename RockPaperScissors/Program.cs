string? inputPlayer;
string inputCPU;
string message;

// Displaying prompt, reading input to and from user
Write("Enter 'ROCK', 'PAPER', or 'SCISSORS':    ");

inputPlayer = ReadLine(); // reads in players move
inputCPU = GenerateMove(); // generates a move for CPU

if (!ValidateInput(inputPlayer)) // if player input is not valid
{
    WriteLine("Please enter 'ROCK', 'PAPER', or 'SCISSORS'");
}

message = PlayGame(inputPlayer, inputCPU);

WriteLine($"Player: {inputPlayer} CPU: {inputCPU}");
WriteLine(message);


