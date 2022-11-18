char[,] grid = new char[9, 9];
void draw()
{

    for (int row = 0; row < grid.GetLength(1); row++)
    {
        for (int column = 0; column < grid.GetLength(1); column++)
            Console.Write(grid[row, column] + "  ");

        Console.WriteLine();
    }
}


int exit = 0;
int playerPosition = 1;
Console.OutputEncoding = System.Text.Encoding.Unicode;
while (exit < 1)
{

    var keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.LeftArrow:
            //rotates ship to the left
            playerPosition++;
            break;
        case ConsoleKey.RightArrow:
            //rotates ship to the right
            playerPosition--;
            break;
        case ConsoleKey.UpArrow:
            //Advances the game one frame
            break;
        case ConsoleKey.Spacebar:
            Console.Beep(500, 250);
            //Shoots the weapon
            break;
        case ConsoleKey.Escape:
            //exits the game
            exit = 1;
            break;
    }
    switch (playerPosition)
    {
        case 0:
            Console.Clear();
            grid[5, 5] = '⯅';
            break;
        case 1:
            Console.Clear();
            grid[5, 5] = '⯅';
            break;
        case 2:
            Console.Clear();
            grid[5, 5] = '◤';
            break;
        case 3:
            Console.Clear();
            grid[5, 5] = '⯇';
            break;
        case 4:
            Console.Clear();
            grid[5, 5] = '◣';
            break;
        case 5:
            Console.Clear();
            grid[5, 5] = '⯆';
            break;
        case 6:
            Console.Clear();
            grid[5, 5] = '◢';
            break;
        case 7:
            Console.Clear();
            grid[5, 5] = '⯈';
            break;
        case 8:
            Console.Clear();
            grid[5, 5] = '◥';
            break;
        case 9:
            Console.Clear();
            grid[5, 5] = '⯅';
            break;

    }
    //cycles through the player position
    if (playerPosition == 9)
    {
        playerPosition = 1;
    }
    else if (playerPosition == 1)
    {
        playerPosition = 9;
    }
    draw();
}

