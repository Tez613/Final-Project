int exit = 0;
int playerPosition = 1;
Console.OutputEncoding = System.Text.Encoding.Unicode;
while (exit < 1)
{
    Console.SetCursorPosition(0, 0);
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
            //Shoots the weapon
            break;
    }
    switch (playerPosition)
    {
         case 0:
            Console.Clear();
            Console.Write('⯅');
            break;
        case 1:
            Console.Clear();
            Console.Write('⯅');
            break;
        case 2:
            Console.Clear();
            Console.Write('◤');
            break;
        case 3:
            Console.Clear();
            Console.Write('⯇');
            break;
        case 4:
            Console.Clear();
            Console.Write('◣');
            break;
        case 5:
            Console.Clear();
            Console.Write('⯆');
            break;
        case 6:
            Console.Clear();
            Console.Write('◢');
            break;
        case 7:
            Console.Clear();
            Console.Write("⯈");
            break;
        case 8:
            Console.Clear();
            Console.Write("◥");
            break;
        case 9:
            Console.Clear();
            Console.Write('⯅');
            break;

    }
    if (playerPosition == 9)
    {
        playerPosition = 1;
    }
    else if (playerPosition == 1)
    {
        playerPosition = 9;
    }
}

int [,] matrix = new int [9,9];
for (int row = 0; row <matrix.GetLength(1); row++)
{
    for(int column = 0; column <matrix.GetLength(1);column++)
        Console.Write(matrix[row, column]+ " ");

    Console.WriteLine();
}