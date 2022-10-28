int exit = 0;
int playerPosition = 1;
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
            //Shoots the weapon
            break;
    }
    switch (playerPosition)
    {
        case 1:
            Console.Clear();
            Console.Write(@"/\");
            break;
        case 2:
            Console.Clear();
            Console.Write(@"|\");
            break;
        case 3:
            Console.Clear();
            Console.Write("<");
            break;
        case 4:
            Console.Clear();
            Console.Write("|/");
            break;
        case 5:
            Console.Clear();
            Console.Write(@"\/");
            break;
        case 6:
            Console.Clear();
            Console.Write(@"\|");
            break;
        case 7:
            Console.Clear();
            Console.Write(">");
            break;
        case 8:
            Console.Clear();
            Console.Write("/|");
            break;
    }
    while (playerPosition > 8)
    {
        playerPosition = 1;
    }
    while (playerPosition < 1)
    {
        playerPosition = 8;
    }
}


