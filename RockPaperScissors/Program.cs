// Player and CPU moves
string? inputPlayer;
string inputCPU;

// Round outcomes
string message; // winner of round

bool flag = true;

// Game counters
int countPlayer = 0;    // player round wins
int countCPU = 0;       // cpu round wins
int round = 0;          // rounds played

Menu(); // Displays the welcome prompt and game directions
WriteLine();

do
{
    Write("Enter 'ROCK', 'PAPER', or 'SCISSORS':    ");
    inputPlayer = GetPlayerMove();  // Gets players move e.g. "ROCK", "PAPER", or "SCISSORS"
    inputCPU = GenerateMove();      // Gets CPUs move e.g. "ROCK", "PAPER", or "SCISSORS"
    WriteLine();

    message = PlayGame(inputPlayer, inputCPU); // Plays round of the game and returns winner

    if (message == "player")    // if player is winner execute statments
    {
        countPlayer += 1;
        round += 1;
        WriteLine($"PLAYER WINS ROUND {round}!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
        
    }
    else if (message == "cpu")  // if cpu is winner execute statements
    {
        countCPU += 1;
        round += 1;
        WriteLine($"CPU WINS ROUND {round}!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
    }
    else                        // if tie execute statements
    {
        round += 1;
        WriteLine($"ROUND {round} DRAW!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
    }

    if (countPlayer == 3 | countCPU == 3) // game over if player or cpu hits 3 round wins
    {
        WriteLine("\n\n\nGAME OVER");
        if (countPlayer == 3)
        {
            WriteLine($"PLAYER WINS!   PLAYER: {countPlayer}    CPU: {countCPU}\n\n");
        }
        else
        {
            WriteLine($"CPU WINS!   PLAYER: {countPlayer}    CPU: {countCPU}\n\n");
        }

        flag = false; // stops game
    }

} while (flag);


