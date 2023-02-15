string? inputPlayer;
string inputCPU;
string message;
int countPlayer = 0;
int countCPU = 0;
int round = 0;
bool flag = true;

Menu();
WriteLine();

do
{
    // get player and cpu input
    Write("Enter 'ROCK', 'PAPER', or 'SCISSORS':    ");
    inputPlayer = GetPlayerMove();
    inputCPU = GenerateMove();
    WriteLine();

    message = PlayGame(inputPlayer, inputCPU);

    if (message == "player")
    {
        countPlayer += 1;
        round += 1;
        WriteLine($"PLAYER WINS ROUND {round}!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
        
    }
    else if (message == "cpu")
    {
        countCPU += 1;
        round += 1;
        WriteLine($"CPU WINS ROUND {round}!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
    }
    else
    {
        round += 1;
        WriteLine($"ROUND {round} DRAW!");
        WriteLine($"PLAYER: {countPlayer}   CPU: {countCPU}\n");
    }

    if (countPlayer == 3 | countCPU == 3)
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

        flag = false;
    }

} while (flag);


