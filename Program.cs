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
int xAxis = 5;
int yAxis = 5;
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
            if (playerPosition == 9)
            {
                playerPosition = 1;
            }
            break;
        case ConsoleKey.RightArrow:
            //rotates ship to the right
            playerPosition--;
            if (playerPosition == 1)
            {
                playerPosition = 9;
            }
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
        case ConsoleKey.A:
            //Move the ship left
            xAxis--;
            if (xAxis == -1)
            {
                xAxis = 8;
            }
            break;
        case ConsoleKey.D:
            //Move the ship right
            xAxis++;
            if (xAxis == 9)
            {
                xAxis = 0;
            }
            break;
        case ConsoleKey.W:
            //Move the ship up
            yAxis--;
            if (yAxis == -1)
            {
                yAxis = 8;
            }
            break;
        case ConsoleKey.S:
            //Move the ship down
            yAxis++;
            if (yAxis == 9)
            {
                yAxis = 0;
            }
            break;
    }
    switch (playerPosition)
    {
        case 1:
            Console.Clear();
            grid[yAxis, xAxis] = '⯅';
            break;
        case 2:
            Console.Clear();
            grid[yAxis, xAxis] = '◤';
            break;
        case 3:
            Console.Clear();
            grid[yAxis, xAxis] = '⯇';
            break;
        case 4:
            Console.Clear();
            grid[yAxis, xAxis] = '◣';
            break;
        case 5:
            Console.Clear();
            grid[yAxis, xAxis] = '⯆';
            break;
        case 6:
            Console.Clear();
            grid[yAxis, xAxis] = '◢';
            break;
        case 7:
            Console.Clear();
            grid[yAxis, xAxis] = '⯈';
            break;
        case 8:
            Console.Clear();
            grid[yAxis, xAxis] = '◥';
            break;
        case 9:
            Console.Clear();
            grid[yAxis, xAxis] = '⯅';
            break;

    }
    draw();
}

