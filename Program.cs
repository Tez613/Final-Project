int GameLoop = 0;
int Difficulty = 2;
string StartDecision = "0";
string DifficultyDecision = "0";



Console.OutputEncoding = System.Text.Encoding.Unicode;
while (GameLoop < 1)
{
    int AstSpawn = 0;
    int Direction = 0;
    int xAxis = 5;
    int yAxis = 5;
    bool exit = true;
    int playerPosition = 1;

    int Ast1X = 0;
    int Ast1Y = 0;
    int Ast1Direction = 0;
    bool Ast1 = false;


    int Ast2X = 0;
    int Ast2Y = 1;
    int Ast2Direction = 0;
    bool Ast2 = false;

    int Ast3X = 0;
    int Ast3Y = 2;
    int Ast3Direction = 0;
    bool Ast3 = false;

    int Ast4X = 0;
    int Ast4Y = 3;
    int Ast4Direction = 0;
    bool Ast4 = false;

    int Ast5X = 0;
    int Ast5Y = 4;
    int Ast5Direction = 0;
    bool Ast5 = false;

    int Ast6X = 0;
    int Ast6Y = 5;
    int Ast6Direction = 0;
    bool Ast6 = false;

    int Ast7X = 0;
    int Ast7Y = 6;
    int Ast7Direction = 0;
    bool Ast7 = false;

    int Ast8X = 0;
    int Ast8Y = 7;
    int Ast8Direction = 0;
    bool Ast8 = false;

    int Ast9X = 1;
    int Ast9Y = 0;
    int Ast9Direction = 0;
    bool Ast9 = false;

    int Ast10X = 2;
    int Ast10Y = 0;
    int Ast10Direction = 0;
    bool Ast10 = false;

    int Ast11X = 3;
    int Ast11Y = 0;
    int Ast11Direction = 0;
    bool Ast11 = false;

    int Ast12X = 4;
    int Ast12Y = 0;
    int Ast12Direction = 0;
    bool Ast12 = false;

    int Ast13X = 5;
    int Ast13Y = 0;
    int Ast13Direction = 0;
    bool Ast13 = false;

    int Ast14X = 6;
    int Ast14Y = 0;
    int Ast14Direction = 0;
    bool Ast14 = false;

    int Ast15X = 7;
    int Ast15Y = 0;
    int Ast15Direction = 0;
    bool Ast15 = false;

    int Ast16X = 8;
    int Ast16Y = 0;
    int Ast16Direction = 0;
    bool Ast16 = false;

    int Ast17X = 8;
    int Ast17Y = 1;
    int Ast17Direction = 0;
    bool Ast17 = false;

    int Ast18X = 8;
    int Ast18Y = 2;
    int Ast18Direction = 0;
    bool Ast18 = false;

    int Ast19X = 8;
    int Ast19Y = 3;
    int Ast19Direction = 0;
    bool Ast19 = false;

    int Ast20X = 8;
    int Ast20Y = 4;
    int Ast20Direction = 0;
    bool Ast20 = false;

    int Ast21X = 8;
    int Ast21Y = 5;
    int Ast21Direction = 0;
    bool Ast21 = false;

    int Ast22X = 8;
    int Ast22Y = 6;
    int Ast22Direction = 0;
    bool Ast22 = false;

    int Ast23X = 8;
    int Ast23Y = 7;
    int Ast23Direction = 0;
    bool Ast23 = false;

    int Ast24X = 8;
    int Ast24Y = 8;
    int Ast24Direction = 0;
    bool Ast24 = false;

    int Ast25X = 7;
    int Ast25Y = 8;
    int Ast25Direction = 0;
    bool Ast25 = false;

    int Ast26X = 6;
    int Ast26Y = 8;
    int Ast26Direction = 0;
    bool Ast26 = false;

    int Ast27X = 5;
    int Ast27Y = 8;
    int Ast27Direction = 0;
    bool Ast27 = false;

    int Ast28X = 4;
    int Ast28Y = 8;
    int Ast28Direction = 0;
    bool Ast28 = false;

    int Ast29X = 3;
    int Ast29Y = 8;
    int Ast29Direction = 0;
    bool Ast29 = false;

    int Ast30X = 2;
    int Ast30Y = 8;
    int Ast30Direction = 0;
    bool Ast30 = false;

    int Ast31X = 1;
    int Ast31Y = 8;
    int Ast31Direction = 0;
    bool Ast31 = false;

    int Ast32X = 0;
    int Ast32Y = 8;
    int Ast32Direction = 0;
    bool Ast32 = false;

    bool bullet1 = false;
    bool bullet2 = false;
    bool bullet3 = false;
    bool bullet4 = false;
    bool bullet5 = false;
    bool bullet6 = false;
    bool bullet7 = false;
    bool bullet8 = false;

    int bullet1x = xAxis;
    int bullet1y = yAxis;

    int bullet2x = xAxis;
    int bullet2y = yAxis;

    int bullet3x = xAxis;
    int bullet3y = yAxis;

    int bullet4x = xAxis;
    int bullet4y = yAxis;

    int bullet5x = xAxis;
    int bullet5y = yAxis;

    int bullet6x = xAxis;
    int bullet6y = yAxis;

    int bullet7x = xAxis;
    int bullet7y = yAxis;

    int bullet8x = xAxis;
    int bullet8y = yAxis;
    Console.Clear();
    Console.WriteLine(" WELCOME TO ASTEROIDS! \n \n \n Please pick an option \n Your options are: \n 1: Play \n 2: Difficutly \n 3: Exit");
    StartDecision = Console.ReadLine();
    switch (StartDecision)
    {
        case "1":
            Console.Clear();
            Console.WriteLine(" The controls are: \n W to move your ship up \n S to move your ship down \n A to move your ship to the left \n D to move to the right \n Left arrow to rotate to the left \n Right arrow to rotate the ship to the right \n Space to shoot \n Down arrow to advance the game one frame \n ESC to go back to the main menu \n Press any key to continue");
            exit = true;
            Console.ReadKey();

            string[,] grid = new string[9, 9];
            void draw()
            {

                for (int row = 0; row < grid.GetLength(1); row++)
                {
                    for (int column = 0; column < grid.GetLength(1); column++)
                        Console.Write(grid[row, column] + "  ");

                    Console.WriteLine();
                }
            }

            while (exit == true)
            {

                Random rand1 = new Random();
                AstSpawn = rand1.Next(Difficulty);
                Random rand2 = new Random();
                Direction = rand2.Next(7);
                var keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        //rotates ship to the left
                        playerPosition++;
                        if (playerPosition >= 8)
                        {
                            playerPosition = 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        //rotates ship to the right
                        playerPosition--;
                        if (playerPosition <= 1)
                        {
                            playerPosition = 9;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        //Advances the game one frame
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Beep(500, 250);
                        switch (playerPosition)
                        {
                            case 1:
                                bullet1 = true;
                                 bullet1x = yAxis;
                                 bullet1y = xAxis;
                                break;
                            case 2:
                                bullet2 = true;
                                 bullet2x = yAxis;
                                 bullet2y = xAxis;
                                break;
                            case 3:
                                bullet3 = true;
                                 bullet3x = yAxis;
                                 bullet3y = xAxis;
                                break;
                            case 4:
                                bullet4 = true;
                                 bullet4x = yAxis;
                                 bullet4y = xAxis;
                                break;
                            case 5:
                                bullet5 = true;
                                 bullet5x = yAxis;
                                 bullet5y = xAxis;
                                break;
                            case 6:
                                bullet6 = true;
                                 bullet6x = yAxis;
                                 bullet6y = xAxis;
                                break;
                            case 7:
                                bullet7 = true;
                                 bullet7x = yAxis;
                                 bullet7y = xAxis;
                                break;
                            case 8:
                                bullet8 = true;
                                 bullet8x = yAxis;
                                 bullet8y = xAxis;

                                break;
                        }
                        //Shoots the weapon
                        break;
                    case ConsoleKey.Escape:
                        //exits the game
                        exit = false;
                        break;
                    case ConsoleKey.A:
                        //Move the ship left
                        grid[yAxis, xAxis] = " ";
                        xAxis--;
                        if (xAxis == -1)
                        {
                            xAxis = 8;
                        }
                        break;
                    case ConsoleKey.D:
                        //Move the ship right
                        grid[yAxis, xAxis] = "  ";
                        xAxis++;
                        if (xAxis == 9)
                        {
                            xAxis = 0;
                        }
                        break;
                    case ConsoleKey.W:
                        //Move the ship up
                        grid[yAxis, xAxis] = "  ";
                        yAxis--;
                        if (yAxis == -1)
                        {
                            yAxis = 8;
                        }
                        break;
                    case ConsoleKey.S:
                        //Move the ship down
                        grid[yAxis, xAxis] = "  ";
                        yAxis++;
                        if (yAxis == 9)
                        {
                            yAxis = 0;
                        }
                        break;
                }
                //Displays the rotation of the ship
                switch (playerPosition)
                {
                    case 1:
                        Console.Clear();
                        grid[yAxis, xAxis] = "⯅ ";
                        break;
                    case 2:
                        Console.Clear();
                        grid[yAxis, xAxis] = "◤ ";
                        break;
                    case 3:
                        Console.Clear();
                        grid[yAxis, xAxis] = "⯇ ";
                        break;
                    case 4:
                        Console.Clear();
                        grid[yAxis, xAxis] = "◣ ";
                        break;
                    case 5:
                        Console.Clear();
                        grid[yAxis, xAxis] = "⯆ ";
                        break;
                    case 6:
                        Console.Clear();
                        grid[yAxis, xAxis] = "◢ ";
                        break;
                    case 7:
                        Console.Clear();
                        grid[yAxis, xAxis] = "⯈ ";
                        break;
                    case 8:
                        Console.Clear();
                        grid[yAxis, xAxis] = "◥ ";
                        break;
                    case 9:
                        Console.Clear();
                        grid[yAxis, xAxis] = "⯅ ";
                        break;

                }
                if (bullet1 == true)
                {
                    if (bullet1x == 0)
                    {
                        bullet1x = 8;
                    }

                    grid[bullet1x, bullet1y] = "  ";
                    bullet1x--;
                    grid[bullet1x, bullet1y] = ". ";
                }
                if (bullet2 == true)
                {
                    if (bullet2x == 0)
                    {
                        bullet2x = 8;
                    }
                    if (bullet2y == 0)
                    {
                        bullet2y = 8;
                    }

                    grid[bullet2x, bullet2y] = "  ";
                    bullet2x--;
                    bullet2y--;
                    grid[bullet2x, bullet2y] = ". ";
                }
                if (bullet3 == true)
                {
                    if (bullet3x == 0)
                    {
                        bullet3x = 8;
                    }
                    if (bullet3y == 0)
                    {
                        bullet3y = 8;
                    }

                    grid[bullet3x, bullet3y] = "  ";
                    bullet3y--;
                    grid[bullet3x, bullet3y] = ". ";
                }
                if (bullet4 == true)
                {
                    if (bullet4x == 8)
                    {
                        bullet4x = 0;
                    }
                    if (bullet4y == 0)
                    {
                        bullet4y = 8;
                    }

                    grid[bullet4x, bullet4y] = "  ";
                    bullet4x++;
                    bullet4y--;
                    grid[bullet4x, bullet4y] = ". ";
                }
                if (bullet5 == true)
                {
                    if (bullet5x == 8)
                    {
                        bullet5x = 0;
                    }

                    grid[bullet5x, bullet5y] = "  ";
                    bullet5x++;
                    grid[bullet5x, bullet5y] = ". ";
                }
                if (bullet6 == true)
                {
                    if (bullet6x == 8)
                    {
                        bullet6x = 0;
                    }
                    if (bullet6y == 8)
                    {
                        bullet6y = 0;
                    }

                    grid[bullet6x, bullet6y] = "  ";
                    bullet6x++;
                    bullet6y++;
                    grid[bullet6x, bullet6y] = ". ";
                }
                if (bullet7 == true)
                {
                    if (bullet7x == 8)
                    {
                        bullet7x = 0;
                    }
                    if (bullet7y == 8)
                    {
                        bullet7y = 0;
                    }

                    grid[bullet7x, bullet7y] = "  ";
                    bullet7y++;
                    grid[bullet7x, bullet7y] = ". ";
                }
                if (bullet8 == true)
                {
                    if (bullet8x == 0)
                    {
                        bullet8x = 8;
                    }
                    if (bullet8y == 8)
                    {
                        bullet8y = 0;
                    }

                    grid[bullet8x, bullet8y] = "  ";
                    bullet8x--;
                    bullet8y++;
                    grid[bullet8x, bullet8y] = ". ";
                }



                switch (AstSpawn)
                {
                    case 1:
                        if (Ast1 == true)
                        {
                            break;
                        }
                        Ast1Direction = Direction;
                        Ast1 = true;
                        break;

                    case 2:
                        if (Ast2 == true)
                        {
                            break;
                        }
                        Ast2Direction = Direction;
                        Ast2 = true;
                        break;

                    case 3:
                        if (Ast3 == true)
                        {
                            break;
                        }
                        Ast3Direction = Direction;
                        Ast3 = true;
                        break;

                    case 4:
                        if (Ast4 == true)
                        {
                            break;
                        }
                        Ast4Direction = Direction;
                        Ast4 = true;
                        break;

                    case 5:
                        if (Ast5 == true)
                        {
                            break;
                        }
                        Ast5Direction = Direction;
                        Ast5 = true;
                        break;

                    case 6:
                        if (Ast6 == true)
                        {
                            break;
                        }
                        Ast6Direction = Direction;
                        Ast6 = true;
                        break;

                    case 7:
                        if (Ast7 == true)
                        {
                            break;
                        }
                        Ast7Direction = Direction;
                        Ast7 = true;
                        break;

                    case 8:
                        if (Ast8 == true)
                        {
                            break;
                        }
                        Ast8Direction = Direction;
                        Ast8 = true;
                        break;

                    case 9:
                        if (Ast9 == true)
                        {
                            break;
                        }
                        Ast9Direction = Direction;
                        Ast9 = true;
                        break;

                    case 10:
                        if (Ast10 == true)
                        {
                            break;
                        }
                        Ast10Direction = Direction;
                        Ast10 = true;
                        break;

                    case 11:
                        if (Ast11 == true)
                        {
                            break;
                        }
                        Ast11Direction = Direction;
                        Ast11 = true;
                        break;

                    case 12:
                        if (Ast12 == true)
                        {
                            break;
                        }
                        Ast12Direction = Direction;
                        Ast12 = true;
                        break;

                    case 13:
                        if (Ast13 == true)
                        {
                            break;
                        }
                        Ast13Direction = Direction;
                        Ast13 = true;
                        break;

                    case 14:
                        if (Ast14 == true)
                        {
                            break;
                        }
                        Ast14Direction = Direction;
                        Ast14 = true;
                        break;

                    case 15:
                        if (Ast15 == true)
                        {
                            break;
                        }
                        Ast15Direction = Direction;
                        Ast15 = true;
                        break;

                    case 16:
                        if (Ast16 == true)
                        {
                            break;
                        }
                        Ast16Direction = Direction;
                        Ast16 = true;
                        break;

                    case 17:
                        if (Ast17 == true)
                        {
                            break;
                        }
                        Ast17Direction = Direction;
                        Ast17 = true;
                        break;

                    case 18:
                        if (Ast18 == true)
                        {
                            break;
                        }
                        Ast18Direction = Direction;
                        Ast18 = true;
                        break;

                    case 19:
                        if (Ast19 == true)
                        {
                            break;
                        }
                        Ast19Direction = Direction;
                        Ast19 = true;
                        break;

                    case 20:
                        if (Ast20 == true)
                        {
                            break;
                        }
                        Ast20Direction = Direction;
                        Ast20 = true;
                        break;

                    case 21:
                        if (Ast21 == true)
                        {
                            break;
                        }
                        Ast21Direction = Direction;
                        Ast21 = true;
                        break;

                    case 22:
                        if (Ast22 == true)
                        {
                            break;
                        }
                        Ast22Direction = Direction;
                        Ast22 = true;
                        break;

                    case 23:
                        if (Ast23 == true)
                        {
                            break;
                        }
                        Ast23Direction = Direction;
                        Ast23 = true;
                        break;

                    case 24:
                        if (Ast24 == true)
                        {
                            break;
                        }
                        Ast24Direction = Direction;
                        Ast24 = true;
                        break;

                    case 25:
                        if (Ast25 == true)
                        {
                            break;
                        }
                        Ast25Direction = Direction;
                        Ast25 = true;
                        break;

                    case 26:
                        if (Ast26 == true)
                        {
                            break;
                        }
                        Ast26Direction = Direction;
                        Ast26 = true;
                        break;

                    case 27:
                        if (Ast27 == true)
                        {
                            break;
                        }
                        Ast27Direction = Direction;
                        Ast27 = true;
                        break;

                    case 28:
                        if (Ast28 == true)
                        {
                            break;
                        }
                        Ast28Direction = Direction;
                        Ast28 = true;
                        break;

                    case 29:
                        if (Ast29 == true)
                        {
                            break;
                        }
                        Ast29Direction = Direction;
                        Ast29 = true;
                        break;

                    case 30:
                        if (Ast30 == true)
                        {
                            break;
                        }
                        Ast30Direction = Direction;
                        Ast30 = true;
                        break;

                    case 31:
                        if (Ast31 == true)
                        {
                            break;
                        }
                        Ast31Direction = Direction;
                        Ast31 = true;
                        break;

                    case 32:
                        if (Ast32 == true)
                        {
                            break;
                        }
                        Ast32Direction = Direction;
                        Ast32 = true;
                        break;
                    default:
                        break;
                }
                //Astroid movement
                if (Ast1 == true)
                {
                    if (Ast1X == yAxis && Ast1Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }
                    switch (Ast1Direction)
                    {
                        case 0:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X--;
                            Ast1Y--;
                            if (Ast1X == -1)
                            {
                                Ast1X = 8;
                            }
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 1:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X--;
                            Ast1Y++;
                            if (Ast1X == -1)
                            {
                                Ast1X = 8;
                            }
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 2:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X++;
                            Ast1Y--;
                            if (Ast1X == -1)
                            {
                                Ast1X = 8;
                            }
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 3:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X++;
                            Ast1Y--;
                            if (Ast1X == -1)
                            {
                                Ast1X = 8;
                            }
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 4:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X--;
                            if (Ast1X == -1)
                            {
                                Ast1X = 8;
                            }
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 5:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1X++;
                            if (Ast1X == 9)
                            {
                                Ast1X = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 6:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1Y--;
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                        case 7:
                            grid[Ast1X, Ast1Y] = "  ";
                            Ast1Y++;
                            if (Ast1Y == -1)
                            {
                                Ast1Y = 8;
                            }
                            if (Ast1Y == 9)
                            {
                                Ast1Y = 0;
                            }
                            grid[Ast1X, Ast1Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast2 == true)
                {
                    if (Ast2X == yAxis && Ast2Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast2Direction)
                    {
                        case 0:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X--;
                            Ast2Y--;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 1:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X--;
                            Ast2Y++;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 2:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X++;
                            Ast2Y--;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 3:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X++;
                            Ast2Y--;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 4:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X--;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 5:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2X++;
                            if (Ast2X == -1)
                            {
                                Ast2X = 8;
                            }
                            if (Ast2X == 9)
                            {
                                Ast2X = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 6:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2Y--;
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                        case 7:
                            grid[Ast2X, Ast2Y] = "  ";
                            Ast2Y++;
                            if (Ast2Y == -1)
                            {
                                Ast2Y = 8;
                            }
                            if (Ast2Y == 9)
                            {
                                Ast2Y = 0;
                            }
                            grid[Ast2X, Ast2Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast3 == true)
                {
                    if (Ast3X == yAxis && Ast3Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast3Direction)
                    {
                        case 0:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X--;
                            Ast3Y--;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 1:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X--;
                            Ast3Y++;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 2:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X++;
                            Ast3Y--;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 3:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X++;
                            Ast3Y--;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 4:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X--;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 5:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3X++;
                            if (Ast3X == -1)
                            {
                                Ast3X = 8;
                            }
                            if (Ast3X == 9)
                            {
                                Ast3X = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 6:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3Y--;
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                        case 7:
                            grid[Ast3X, Ast3Y] = "  ";
                            Ast3Y++;
                            if (Ast3Y == -1)
                            {
                                Ast3Y = 8;
                            }
                            if (Ast3Y == 9)
                            {
                                Ast3Y = 0;
                            }
                            grid[Ast3X, Ast3Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast4 == true)
                {
                    if (Ast4X == yAxis && Ast4Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast4Direction)
                    {
                        case 0:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X--;
                            Ast4Y--;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 1:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X--;
                            Ast4Y++;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 2:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X++;
                            Ast4Y--;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 3:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X++;
                            Ast4Y--;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 4:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X--;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 5:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4X++;
                            if (Ast4X == -1)
                            {
                                Ast4X = 8;
                            }
                            if (Ast4X == 9)
                            {
                                Ast4X = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 6:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4Y--;
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                        case 7:
                            grid[Ast4X, Ast4Y] = "  ";
                            Ast4Y++;
                            if (Ast4Y == -1)
                            {
                                Ast4Y = 8;
                            }
                            if (Ast4Y == 9)
                            {
                                Ast4Y = 0;
                            }
                            grid[Ast4X, Ast4Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast5 == true)
                {
                    if (Ast5X == yAxis && Ast5Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }
                    switch (Ast5Direction)
                    {
                        case 0:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X--;
                            Ast5Y--;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 1:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X--;
                            Ast5Y++;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 2:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X++;
                            Ast5Y--;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 3:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X++;
                            Ast5Y--;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 4:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X--;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 5:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5X++;
                            if (Ast5X == -1)
                            {
                                Ast5X = 8;
                            }
                            if (Ast5X == 9)
                            {
                                Ast5X = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 6:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5Y--;
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                        case 7:
                            grid[Ast5X, Ast5Y] = "  ";
                            Ast5Y++;
                            if (Ast5Y == -1)
                            {
                                Ast5Y = 8;
                            }
                            if (Ast5Y == 9)
                            {
                                Ast5Y = 0;
                            }
                            grid[Ast5X, Ast5Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast6 == true)
                {
                    if (Ast6X == yAxis && Ast6Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast6Direction)
                    {

                        case 0:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X--;
                            Ast6Y--;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 1:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X--;
                            Ast6Y++;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 2:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X++;
                            Ast6Y--;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 3:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X++;
                            Ast6Y--;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 4:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X--;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 5:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6X++;
                            if (Ast6X == -1)
                            {
                                Ast6X = 8;
                            }
                            if (Ast6X == 9)
                            {
                                Ast6X = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 6:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6Y--;
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                        case 7:
                            grid[Ast6X, Ast6Y] = "  ";
                            Ast6Y++;
                            if (Ast6Y == -1)
                            {
                                Ast6Y = 8;
                            }
                            if (Ast6Y == 9)
                            {
                                Ast6Y = 0;
                            }
                            grid[Ast6X, Ast6Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast7 == true)
                {
                    if (Ast7X == yAxis && Ast7Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast7Direction)
                    {
                        case 0:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X--;
                            Ast7Y--;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 1:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X--;
                            Ast7Y++;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 2:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X++;
                            Ast7Y--;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 3:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X++;
                            Ast7Y--;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 4:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X--;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 5:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7X++;
                            if (Ast7X == -1)
                            {
                                Ast7X = 8;
                            }
                            if (Ast7X == 9)
                            {
                                Ast7X = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 6:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7Y--;
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                        case 7:
                            grid[Ast7X, Ast7Y] = "  ";
                            Ast7Y++;
                            if (Ast7Y == -1)
                            {
                                Ast7Y = 8;
                            }
                            if (Ast7Y == 9)
                            {
                                Ast7Y = 0;
                            }
                            grid[Ast7X, Ast7Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast8 == true)
                {
                    if (Ast8X == yAxis && Ast8Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast8Direction)
                    {
                        case 0:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X--;
                            Ast8Y--;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 1:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X--;
                            Ast8Y++;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 2:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X++;
                            Ast8Y--;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 3:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X++;
                            Ast8Y--;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 4:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X--;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 5:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8X++;
                            if (Ast8X == -1)
                            {
                                Ast8X = 8;
                            }
                            if (Ast8X == 9)
                            {
                                Ast8X = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 6:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8Y--;
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                        case 7:
                            grid[Ast8X, Ast8Y] = "  ";
                            Ast8Y++;
                            if (Ast8Y == -1)
                            {
                                Ast8Y = 8;
                            }
                            if (Ast8Y == 9)
                            {
                                Ast8Y = 0;
                            }
                            grid[Ast8X, Ast8Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast9 == true)
                {
                    if (Ast9X == yAxis && Ast9Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast9Direction)
                    {
                        case 0:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X--;
                            Ast9Y--;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 1:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X--;
                            Ast9Y++;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 2:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X++;
                            Ast9Y--;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 3:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X++;
                            Ast9Y--;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 4:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X--;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 5:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9X++;
                            if (Ast9X == -1)
                            {
                                Ast9X = 8;
                            }
                            if (Ast9X == 9)
                            {
                                Ast9X = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 6:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9Y--;
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                        case 7:
                            grid[Ast9X, Ast9Y] = "  ";
                            Ast9Y++;
                            if (Ast9Y == -1)
                            {
                                Ast9Y = 8;
                            }
                            if (Ast9Y == 9)
                            {
                                Ast9Y = 0;
                            }
                            grid[Ast9X, Ast9Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast10 == true)
                {
                    if (Ast10X == yAxis && Ast10Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast10Direction)
                    {
                        case 0:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X--;
                            Ast10Y--;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 1:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X--;
                            Ast10Y++;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 2:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X++;
                            Ast10Y--;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 3:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X++;
                            Ast10Y--;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 4:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X--;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 5:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10X++;
                            if (Ast10X == -1)
                            {
                                Ast10X = 8;
                            }
                            if (Ast10X == 9)
                            {
                                Ast10X = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 6:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10Y--;
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                        case 7:
                            grid[Ast10X, Ast10Y] = "  ";
                            Ast10Y++;
                            if (Ast10Y == -1)
                            {
                                Ast10Y = 8;
                            }
                            if (Ast10Y == 9)
                            {
                                Ast10Y = 0;
                            }
                            grid[Ast10X, Ast10Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast11 == true)
                {
                    if (Ast11X == yAxis && Ast11Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast11Direction)
                    {
                        case 0:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X--;
                            Ast11Y--;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 1:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X--;
                            Ast11Y++;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 2:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X++;
                            Ast11Y--;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 3:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X++;
                            Ast11Y--;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 4:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X--;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 5:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11X++;
                            if (Ast11X == -1)
                            {
                                Ast11X = 8;
                            }
                            if (Ast11X == 9)
                            {
                                Ast11X = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 6:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11Y--;
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                        case 7:
                            grid[Ast11X, Ast11Y] = "  ";
                            Ast11Y++;
                            if (Ast11Y == -1)
                            {
                                Ast11Y = 8;
                            }
                            if (Ast11Y == 9)
                            {
                                Ast11Y = 0;
                            }
                            grid[Ast11X, Ast11Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast12 == true)
                {
                    if (Ast12X == yAxis && Ast12Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast12Direction)
                    {
                        case 0:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X--;
                            Ast12Y--;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 1:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X--;
                            Ast12Y++;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 2:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X++;
                            Ast12Y--;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 3:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X++;
                            Ast12Y--;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 4:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X--;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 5:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12X++;
                            if (Ast12X == -1)
                            {
                                Ast12X = 8;
                            }
                            if (Ast12X == 9)
                            {
                                Ast12X = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 6:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12Y--;
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                        case 7:
                            grid[Ast12X, Ast12Y] = "  ";
                            Ast12Y++;
                            if (Ast12Y == -1)
                            {
                                Ast12Y = 8;
                            }
                            if (Ast12Y == 9)
                            {
                                Ast12Y = 0;
                            }
                            grid[Ast12X, Ast12Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast13 == true)
                {
                    if (Ast13X == yAxis && Ast13Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast13Direction)
                    {
                        case 0:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X--;
                            Ast13Y--;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 1:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X--;
                            Ast13Y++;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 2:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X++;
                            Ast13Y--;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 3:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X++;
                            Ast13Y--;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 4:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X--;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 5:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13X++;
                            if (Ast13X == -1)
                            {
                                Ast13X = 8;
                            }
                            if (Ast13X == 9)
                            {
                                Ast13X = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 6:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13Y--;
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                        case 7:
                            grid[Ast13X, Ast13Y] = "  ";
                            Ast13Y++;
                            if (Ast13Y == -1)
                            {
                                Ast13Y = 8;
                            }
                            if (Ast13Y == 9)
                            {
                                Ast13Y = 0;
                            }
                            grid[Ast13X, Ast13Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast14 == true)
                {
                    if (Ast14X == yAxis && Ast14Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast14Direction)
                    {
                        case 0:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X--;
                            Ast14Y--;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 1:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X--;
                            Ast14Y++;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 2:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X++;
                            Ast14Y--;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 3:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X++;
                            Ast14Y--;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 4:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X--;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 5:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14X++;
                            if (Ast14X == -1)
                            {
                                Ast14X = 8;
                            }
                            if (Ast14X == 9)
                            {
                                Ast14X = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 6:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14Y--;
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                        case 7:
                            grid[Ast14X, Ast14Y] = "  ";
                            Ast14Y++;
                            if (Ast14Y == -1)
                            {
                                Ast14Y = 8;
                            }
                            if (Ast14Y == 9)
                            {
                                Ast14Y = 0;
                            }
                            grid[Ast14X, Ast14Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast15 == true)
                {
                    if (Ast15X == yAxis && Ast15Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast15Direction)
                    {
                        case 0:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X--;
                            Ast15Y--;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 1:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X--;
                            Ast15Y++;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 2:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X++;
                            Ast15Y--;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 3:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X++;
                            Ast15Y--;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 4:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X--;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 5:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15X++;
                            if (Ast15X == -1)
                            {
                                Ast15X = 8;
                            }
                            if (Ast15X == 9)
                            {
                                Ast15X = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 6:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15Y--;
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                        case 7:
                            grid[Ast15X, Ast15Y] = "  ";
                            Ast15Y++;
                            if (Ast15Y == -1)
                            {
                                Ast15Y = 8;
                            }
                            if (Ast15Y == 9)
                            {
                                Ast15Y = 0;
                            }
                            grid[Ast15X, Ast15Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast16 == true)
                {
                    if (Ast16X == yAxis && Ast16Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast16Direction)
                    {
                        case 0:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X--;
                            Ast16Y--;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 1:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X--;
                            Ast16Y++;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 2:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X++;
                            Ast16Y--;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 3:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X++;
                            Ast16Y--;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 4:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X--;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 5:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16X++;
                            if (Ast16X == -1)
                            {
                                Ast16X = 8;
                            }
                            if (Ast16X == 9)
                            {
                                Ast16X = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 6:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16Y--;
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                        case 7:
                            grid[Ast16X, Ast16Y] = "  ";
                            Ast16Y++;
                            if (Ast16Y == -1)
                            {
                                Ast16Y = 8;
                            }
                            if (Ast16Y == 9)
                            {
                                Ast16Y = 0;
                            }
                            grid[Ast16X, Ast16Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast17 == true)
                {
                    if (Ast17X == yAxis && Ast17Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast17Direction)
                    {
                        case 0:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X--;
                            Ast17Y--;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 1:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X--;
                            Ast17Y++;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 2:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X++;
                            Ast17Y--;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 3:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X++;
                            Ast17Y--;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 4:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X--;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 5:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17X++;
                            if (Ast17X == -1)
                            {
                                Ast17X = 8;
                            }
                            if (Ast17X == 9)
                            {
                                Ast17X = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 6:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17Y--;
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                        case 7:
                            grid[Ast17X, Ast17Y] = "  ";
                            Ast17Y++;
                            if (Ast17Y == -1)
                            {
                                Ast17Y = 8;
                            }
                            if (Ast17Y == 9)
                            {
                                Ast17Y = 0;
                            }
                            grid[Ast17X, Ast17Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast18 == true)
                {
                    if (Ast18X == yAxis && Ast18Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast18Direction)
                    {
                        case 0:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X--;
                            Ast18Y--;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 1:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X--;
                            Ast18Y++;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 2:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X++;
                            Ast18Y--;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 3:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X++;
                            Ast18Y--;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 4:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X--;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 5:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18X++;
                            if (Ast18X == -1)
                            {
                                Ast18X = 8;
                            }
                            if (Ast18X == 9)
                            {
                                Ast18X = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 6:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18Y--;
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                        case 7:
                            grid[Ast18X, Ast18Y] = "  ";
                            Ast18Y++;
                            if (Ast18Y == -1)
                            {
                                Ast18Y = 8;
                            }
                            if (Ast18Y == 9)
                            {
                                Ast18Y = 0;
                            }
                            grid[Ast18X, Ast18Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast19 == true)
                {
                    if (Ast19X == yAxis && Ast19Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast19Direction)
                    {
                        case 0:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X--;
                            Ast19Y--;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 1:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X--;
                            Ast19Y++;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 2:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X++;
                            Ast19Y--;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 3:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X++;
                            Ast19Y--;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 4:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X--;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 5:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19X++;
                            if (Ast19X == -1)
                            {
                                Ast19X = 8;
                            }
                            if (Ast19X == 9)
                            {
                                Ast19X = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 6:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19Y--;
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                        case 7:
                            grid[Ast19X, Ast19Y] = "  ";
                            Ast19Y++;
                            if (Ast19Y == -1)
                            {
                                Ast19Y = 8;
                            }
                            if (Ast19Y == 9)
                            {
                                Ast19Y = 0;
                            }
                            grid[Ast19X, Ast19Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast20 == true)
                {
                    if (Ast20X == yAxis && Ast20Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast20Direction)
                    {
                        case 0:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X--;
                            Ast20Y--;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 1:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X--;
                            Ast20Y++;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 2:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X++;
                            Ast20Y--;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 3:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X++;
                            Ast20Y--;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 4:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X--;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 5:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20X++;
                            if (Ast20X == -1)
                            {
                                Ast20X = 8;
                            }
                            if (Ast20X == 9)
                            {
                                Ast20X = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 6:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20Y--;
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                        case 7:
                            grid[Ast20X, Ast20Y] = "  ";
                            Ast20Y++;
                            if (Ast20Y == -1)
                            {
                                Ast20Y = 8;
                            }
                            if (Ast20Y == 9)
                            {
                                Ast20Y = 0;
                            }
                            grid[Ast20X, Ast20Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast21 == true)
                {
                    if (Ast21X == yAxis && Ast21Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast21Direction)
                    {
                        case 0:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X--;
                            Ast21Y--;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 1:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X--;
                            Ast21Y++;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 2:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X++;
                            Ast21Y--;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 3:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X++;
                            Ast21Y--;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 4:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X--;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 5:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21X++;
                            if (Ast21X == -1)
                            {
                                Ast21X = 8;
                            }
                            if (Ast21X == 9)
                            {
                                Ast21X = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 6:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21Y--;
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                        case 7:
                            grid[Ast21X, Ast21Y] = "  ";
                            Ast21Y++;
                            if (Ast21Y == -1)
                            {
                                Ast21Y = 8;
                            }
                            if (Ast21Y == 9)
                            {
                                Ast21Y = 0;
                            }
                            grid[Ast21X, Ast21Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast22 == true)
                {
                    if (Ast22X == yAxis && Ast22Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast22Direction)
                    {
                        case 0:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X--;
                            Ast22Y--;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 1:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X--;
                            Ast22Y++;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 2:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X++;
                            Ast22Y--;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 3:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X++;
                            Ast22Y--;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 4:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X--;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 5:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22X++;
                            if (Ast22X == -1)
                            {
                                Ast22X = 8;
                            }
                            if (Ast22X == 9)
                            {
                                Ast22X = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 6:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22Y--;
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                        case 7:
                            grid[Ast22X, Ast22Y] = "  ";
                            Ast22Y++;
                            if (Ast22Y == -1)
                            {
                                Ast22Y = 8;
                            }
                            if (Ast22Y == 9)
                            {
                                Ast22Y = 0;
                            }
                            grid[Ast22X, Ast22Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast23 == true)
                {
                    if (Ast23X == yAxis && Ast23Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast23Direction)
                    {
                        case 0:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X--;
                            Ast23Y--;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 1:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X--;
                            Ast23Y++;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 2:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X++;
                            Ast23Y--;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 3:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X++;
                            Ast23Y--;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 4:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X--;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 5:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23X++;
                            if (Ast23X == -1)
                            {
                                Ast23X = 8;
                            }
                            if (Ast23X == 9)
                            {
                                Ast23X = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 6:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23Y--;
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                        case 7:
                            grid[Ast23X, Ast23Y] = "  ";
                            Ast23Y++;
                            if (Ast23Y == -1)
                            {
                                Ast23Y = 8;
                            }
                            if (Ast23Y == 9)
                            {
                                Ast23Y = 0;
                            }
                            grid[Ast23X, Ast23Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast24 == true)
                {
                    if (Ast24X == yAxis && Ast24Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast24Direction)
                    {
                        case 0:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X--;
                            Ast24Y--;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 1:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X--;
                            Ast24Y++;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 2:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X++;
                            Ast24Y--;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 3:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X++;
                            Ast24Y--;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 4:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X--;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 5:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24X++;
                            if (Ast24X == -1)
                            {
                                Ast24X = 8;
                            }
                            if (Ast24X == 9)
                            {
                                Ast24X = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 6:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24Y--;
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                        case 7:
                            grid[Ast24X, Ast24Y] = "  ";
                            Ast24Y++;
                            if (Ast24Y == -1)
                            {
                                Ast24Y = 8;
                            }
                            if (Ast24Y == 9)
                            {
                                Ast24Y = 0;
                            }
                            grid[Ast24X, Ast24Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast25 == true)
                {
                    if (Ast25X == yAxis && Ast25Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast25Direction)
                    {
                        case 0:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X--;
                            Ast25Y--;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 1:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X--;
                            Ast25Y++;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 2:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X++;
                            Ast25Y--;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 3:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X++;
                            Ast25Y--;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 4:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X--;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 5:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25X++;
                            if (Ast25X == -1)
                            {
                                Ast25X = 8;
                            }
                            if (Ast25X == 9)
                            {
                                Ast25X = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 6:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25Y--;
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                        case 7:
                            grid[Ast25X, Ast25Y] = "  ";
                            Ast25Y++;
                            if (Ast25Y == -1)
                            {
                                Ast25Y = 8;
                            }
                            if (Ast25Y == 9)
                            {
                                Ast25Y = 0;
                            }
                            grid[Ast25X, Ast25Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast26 == true)
                {
                    if (Ast26X == yAxis && Ast26Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast26Direction)
                    {
                        case 0:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X--;
                            Ast26Y--;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 1:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X--;
                            Ast26Y++;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 2:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X++;
                            Ast26Y--;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 3:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X++;
                            Ast26Y--;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 4:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X--;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 5:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26X++;
                            if (Ast26X == -1)
                            {
                                Ast26X = 8;
                            }
                            if (Ast26X == 9)
                            {
                                Ast26X = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 6:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26Y--;
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                        case 7:
                            grid[Ast26X, Ast26Y] = "  ";
                            Ast26Y++;
                            if (Ast26Y == -1)
                            {
                                Ast26Y = 8;
                            }
                            if (Ast26Y == 9)
                            {
                                Ast26Y = 0;
                            }
                            grid[Ast26X, Ast26Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast27 == true)
                {
                    if (Ast27X == yAxis && Ast27Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast27Direction)
                    {
                        case 0:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X--;
                            Ast27Y--;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 1:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X--;
                            Ast27Y++;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 2:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X++;
                            Ast27Y--;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 3:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X++;
                            Ast27Y--;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 4:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X--;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 5:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27X++;
                            if (Ast27X == -1)
                            {
                                Ast27X = 8;
                            }
                            if (Ast27X == 9)
                            {
                                Ast27X = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 6:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27Y--;
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                        case 7:
                            grid[Ast27X, Ast27Y] = "  ";
                            Ast27Y++;
                            if (Ast27Y == -1)
                            {
                                Ast27Y = 8;
                            }
                            if (Ast27Y == 9)
                            {
                                Ast27Y = 0;
                            }
                            grid[Ast27X, Ast27Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast28 == true)
                {
                    if (Ast28X == yAxis && Ast28Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast28Direction)
                    {
                        case 0:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X--;
                            Ast28Y--;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 1:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X--;
                            Ast28Y++;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 2:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X++;
                            Ast28Y--;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 3:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X++;
                            Ast28Y--;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 4:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X--;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 5:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28X++;
                            if (Ast28X == -1)
                            {
                                Ast28X = 8;
                            }
                            if (Ast28X == 9)
                            {
                                Ast28X = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 6:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28Y--;
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                        case 7:
                            grid[Ast28X, Ast28Y] = "  ";
                            Ast28Y++;
                            if (Ast28Y == -1)
                            {
                                Ast28Y = 8;
                            }
                            if (Ast28Y == 9)
                            {
                                Ast28Y = 0;
                            }
                            grid[Ast28X, Ast28Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast29 == true)
                {
                    if (Ast29X == yAxis && Ast29Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast29Direction)
                    {
                        case 0:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X--;
                            Ast29Y--;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 1:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X--;
                            Ast29Y++;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 2:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X++;
                            Ast29Y--;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 3:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X++;
                            Ast29Y--;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 4:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X--;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 5:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29X++;
                            if (Ast29X == -1)
                            {
                                Ast29X = 8;
                            }
                            if (Ast29X == 9)
                            {
                                Ast29X = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 6:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29Y--;
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                        case 7:
                            grid[Ast29X, Ast29Y] = "  ";
                            Ast29Y++;
                            if (Ast29Y == -1)
                            {
                                Ast29Y = 8;
                            }
                            if (Ast29Y == 9)
                            {
                                Ast29Y = 0;
                            }
                            grid[Ast29X, Ast29Y] = "* ";
                            break;
                    }
                }
                //This is a vusiual que so you can see where the switch ends
                if (Ast30 == true)
                {
                    if (Ast30X == yAxis && Ast30Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast30Direction)
                    {
                        case 0:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X--;
                            Ast30Y--;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 1:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X--;
                            Ast30Y++;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 2:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X++;
                            Ast30Y--;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 3:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X++;
                            Ast30Y--;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 4:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X--;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 5:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30X++;
                            if (Ast30X == -1)
                            {
                                Ast30X = 8;
                            }
                            if (Ast30X == 9)
                            {
                                Ast30X = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 6:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30Y--;
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                        case 7:
                            grid[Ast30X, Ast30Y] = "  ";
                            Ast30Y++;
                            if (Ast30Y == -1)
                            {
                                Ast30Y = 8;
                            }
                            if (Ast30Y == 9)
                            {
                                Ast30Y = 0;
                            }
                            grid[Ast30X, Ast30Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast31 == true)
                {
                    if (Ast31X == yAxis && Ast31Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast31Direction)
                    {
                        case 0:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X--;
                            Ast31Y--;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 1:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X--;
                            Ast31Y++;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 2:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X++;
                            Ast31Y--;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 3:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X++;
                            Ast31Y--;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 4:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X--;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 5:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31X++;
                            if (Ast31X == -1)
                            {
                                Ast31X = 8;
                            }
                            if (Ast31X == 9)
                            {
                                Ast31X = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 6:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31Y--;
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                        case 7:
                            grid[Ast31X, Ast31Y] = "  ";
                            Ast31Y++;
                            if (Ast31Y == -1)
                            {
                                Ast31Y = 8;
                            }
                            if (Ast31Y == 9)
                            {
                                Ast31Y = 0;
                            }
                            grid[Ast31X, Ast31Y] = "* ";
                            break;
                    }
                }

                //This is a vusiual que so you can see where the switch ends
                if (Ast32 == true)
                {
                    if (Ast32X == yAxis && Ast32Y == xAxis)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over \n Press any key to continue");
                        Console.ReadKey();
                        exit = false;
                    }

                    switch (Ast32Direction)
                    {
                        case 0:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X--;
                            Ast32Y--;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 1:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X--;
                            Ast32Y++;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 2:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X++;
                            Ast32Y--;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 3:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X++;
                            Ast32Y--;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 4:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X--;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 5:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32X++;
                            if (Ast32X == -1)
                            {
                                Ast32X = 8;
                            }
                            if (Ast32X == 9)
                            {
                                Ast32X = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 6:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32Y--;
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                        case 7:
                            grid[Ast32X, Ast32Y] = "  ";
                            Ast32Y++;
                            if (Ast32Y == -1)
                            {
                                Ast32Y = 8;
                            }
                            if (Ast32Y == 9)
                            {
                                Ast32Y = 0;
                            }
                            grid[Ast32X, Ast32Y] = "* ";
                            break;
                    }
                }
                // This set the collision for the bullets
                //block break
                if(bullet1x == Ast1X && bullet1y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast2X && bullet1y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast3X && bullet1y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast4X && bullet1y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast5X && bullet1y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast6X && bullet1y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast7X && bullet1y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast8X && bullet1y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast9X && bullet1y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast10X && bullet1y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast11X && bullet1y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast12X && bullet1y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast13X && bullet1y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast14X && bullet1y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast15X && bullet1y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                if(bullet1x == Ast16X && bullet1y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast17X && bullet1y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast18X && bullet1y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast19X && bullet1y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast20X && bullet1y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast21X && bullet1y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast22X && bullet1y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast23X && bullet1y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast24X && bullet1y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast25X && bullet1y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast26X && bullet1y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast27X && bullet1y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast28X && bullet1y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast29X && bullet1y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast30X && bullet1y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast31X && bullet1y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
                                if(bullet1x == Ast32X && bullet1y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet1x = yAxis;
                    bullet1y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet1 = false;
                }
  
//block break
                if(bullet2x == Ast1X && bullet2y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast2X && bullet2y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast3X && bullet2y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast4X && bullet2y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast5X && bullet2y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast6X && bullet2y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast7X && bullet2y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast8X && bullet2y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast9X && bullet2y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast10X && bullet2y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast11X && bullet2y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast12X && bullet2y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast13X && bullet2y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast14X && bullet2y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast15X && bullet2y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                if(bullet2x == Ast16X && bullet2y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast17X && bullet2y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast18X && bullet2y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast19X && bullet2y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast20X && bullet2y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast21X && bullet2y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast22X && bullet2y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast23X && bullet2y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast24X && bullet2y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast25X && bullet2y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast26X && bullet2y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast27X && bullet2y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast28X && bullet2y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast29X && bullet2y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast30X && bullet2y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast31X && bullet2y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }
                                if(bullet2x == Ast32X && bullet2y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet2x = yAxis;
                    bullet2y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet2  = false;
                }

//block break
                if(bullet3x == Ast1X && bullet3y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast2X && bullet3y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast3X && bullet3y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast4X && bullet3y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast5X && bullet3y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast6X && bullet3y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast7X && bullet3y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast8X && bullet3y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast9X && bullet3y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast10X && bullet3y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast11X && bullet3y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast12X && bullet3y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast13X && bullet3y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast14X && bullet3y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast15X && bullet3y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                if(bullet3x == Ast16X && bullet3y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast17X && bullet3y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast18X && bullet3y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast19X && bullet3y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast20X && bullet3y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast21X && bullet3y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast22X && bullet3y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast23X && bullet3y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast24X && bullet3y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast25X && bullet3y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast26X && bullet3y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast27X && bullet3y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast28X && bullet3y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast29X && bullet3y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast30X && bullet3y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast31X && bullet3y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }
                                if(bullet3x == Ast32X && bullet3y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet3x = yAxis;
                    bullet3y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet3  = false;
                }

//block break
                if(bullet4x == Ast1X && bullet4y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast2X && bullet4y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast3X && bullet4y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast4X && bullet4y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast5X && bullet4y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast6X && bullet4y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast7X && bullet4y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast8X && bullet4y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast9X && bullet4y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast10X && bullet4y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast11X && bullet4y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast12X && bullet4y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast13X && bullet4y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast14X && bullet4y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast15X && bullet4y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                if(bullet4x == Ast16X && bullet4y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast17X && bullet4y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast18X && bullet4y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast19X && bullet4y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast20X && bullet4y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast21X && bullet4y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast22X && bullet4y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast23X && bullet4y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast24X && bullet4y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast25X && bullet4y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast26X && bullet4y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast27X && bullet4y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast28X && bullet4y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast29X && bullet4y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast30X && bullet4y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast31X && bullet4y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }
                                if(bullet4x == Ast32X && bullet4y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet4x = yAxis;
                    bullet4y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet4  = false;
                }

//block break
                if(bullet5x == Ast1X && bullet5y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast2X && bullet5y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast3X && bullet5y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast4X && bullet5y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast5X && bullet5y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast6X && bullet5y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast7X && bullet5y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast8X && bullet5y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast9X && bullet5y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast10X && bullet5y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast11X && bullet5y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast12X && bullet5y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast13X && bullet5y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast14X && bullet5y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast15X && bullet5y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                if(bullet5x == Ast16X && bullet5y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast17X && bullet5y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast18X && bullet5y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast19X && bullet5y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast20X && bullet5y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast21X && bullet5y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast22X && bullet5y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast23X && bullet5y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast24X && bullet5y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast25X && bullet5y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast26X && bullet5y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast27X && bullet5y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast28X && bullet5y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast29X && bullet5y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast30X && bullet5y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast31X && bullet5y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }
                                if(bullet5x == Ast32X && bullet5y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet5x = yAxis;
                    bullet5y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet5  = false;
                }

//block break
                if(bullet6x == Ast1X && bullet6y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast2X && bullet6y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast3X && bullet6y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast4X && bullet6y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast5X && bullet6y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast6X && bullet6y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast7X && bullet6y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast8X && bullet6y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast9X && bullet6y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast10X && bullet6y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast11X && bullet6y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast12X && bullet6y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast13X && bullet6y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast14X && bullet6y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast15X && bullet6y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                if(bullet6x == Ast16X && bullet6y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast17X && bullet6y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast18X && bullet6y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast19X && bullet6y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast20X && bullet6y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast21X && bullet6y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast22X && bullet6y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast23X && bullet6y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast24X && bullet6y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast25X && bullet6y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast26X && bullet6y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast27X && bullet6y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast28X && bullet6y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast29X && bullet6y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast30X && bullet6y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast31X && bullet6y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }
                                if(bullet6x == Ast32X && bullet6y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet6x = yAxis;
                    bullet6y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet6  = false;
                }

//block break
                if(bullet7x == Ast1X && bullet7y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast2X && bullet7y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast3X && bullet7y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast4X && bullet7y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast5X && bullet7y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast6X && bullet7y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast7X && bullet7y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast8X && bullet7y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast9X && bullet7y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast10X && bullet7y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast11X && bullet7y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast12X && bullet7y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast13X && bullet7y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast14X && bullet7y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast15X && bullet7y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                if(bullet7x == Ast16X && bullet7y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast17X && bullet7y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast18X && bullet7y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast19X && bullet7y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast20X && bullet7y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast21X && bullet7y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast22X && bullet7y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast23X && bullet7y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast24X && bullet7y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast25X && bullet7y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast26X && bullet7y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast27X && bullet7y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast28X && bullet7y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast29X && bullet7y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast30X && bullet7y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast31X && bullet7y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                                if(bullet7x == Ast32X && bullet7y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet7x = yAxis;
                    bullet7y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet7  = false;
                }
                
//block break
                if(bullet8x == Ast1X && bullet8y == Ast1Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast1X = 0;
                    Ast1Y = 0;
                    grid[Ast1X,Ast1Y] ="  ";
                    Ast1Direction = 0;
                    Ast1 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast2X && bullet8y == Ast2Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast2X = 0;
                    Ast2Y = 1;
                    grid[Ast2X,Ast2Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast3X && bullet8y == Ast3Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast3X = 0;
                    Ast3Y = 2;
                    grid[Ast3X,Ast3Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast4X && bullet8y == Ast4Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast4X = 0;
                    Ast4Y = 3;
                    grid[Ast4X,Ast4Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast5X && bullet8y == Ast5Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast5X = 0;
                    Ast5Y = 4;
                    grid[Ast5X,Ast5Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast6X && bullet8y == Ast6Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast6X = 0;
                    Ast6Y = 5;
                    grid[Ast6X,Ast6Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast7X && bullet8y == Ast7Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast7X = 0;
                    Ast7Y = 6;
                    grid[Ast7X,Ast7Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast8X && bullet8y == Ast8Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast8X = 0;
                    Ast8Y = 7;
                    grid[Ast8X,Ast8Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast9X && bullet8y == Ast9Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast9X = 1;
                    Ast9Y = 0;
                    grid[Ast9X,Ast9Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast10X && bullet8y == Ast10Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast10X = 2;
                    Ast10Y = 0;
                    grid[Ast10X,Ast10Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast11X && bullet8y == Ast11Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast11X = 3;
                    Ast11Y = 0;
                    grid[Ast11X,Ast11Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast12X && bullet8y == Ast12Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast12X = 4;
                    Ast12Y = 0;
                    grid[Ast12X,Ast12Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast13X && bullet8y == Ast13Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast13X = 5;
                    Ast13Y = 0;
                    grid[Ast13X,Ast13Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast14X && bullet8y == Ast14Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast14X = 6;
                    Ast14Y = 0;
                    grid[Ast14X,Ast14Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast15X && bullet8y == Ast15Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast15X = 7;
                    Ast15Y = 0;
                    grid[Ast15X,Ast15Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                if(bullet8x == Ast16X && bullet8y == Ast16Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast16X = 8;
                    Ast16Y = 0;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast17X && bullet8y == Ast17Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast17X = 8;
                    Ast17Y = 1;
                    grid[Ast17X,Ast17Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast18X && bullet8y == Ast18Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast18X = 8;
                    Ast18Y = 2;
                    grid[Ast18X,Ast18Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast19X && bullet8y == Ast19Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast19X = 8;
                    Ast19Y = 3;
                    grid[Ast19X,Ast19Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast20X && bullet8y == Ast20Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast20X = 8;
                    Ast20Y = 4;
                    grid[Ast20X,Ast20Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast21X && bullet8y == Ast21Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast21X = 8;
                    Ast21Y = 5;
                    grid[Ast21X,Ast21Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast22X && bullet8y == Ast22Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast22X = 8;
                    Ast22Y = 6;
                    grid[Ast22X,Ast22Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast23X && bullet8y == Ast23Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast23X = 8;
                    Ast23Y = 7;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast24X && bullet8y == Ast24Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast24X = 8;
                    Ast24Y = 8;
                    grid[Ast24X,Ast24Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast25X && bullet8y == Ast25Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast25X = 7;
                    Ast25Y = 8;
                    grid[Ast25X,Ast25Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast26X && bullet8y == Ast26Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast26X = 6;
                    Ast26Y = 8;
                    grid[Ast26X,Ast26Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast27X && bullet8y == Ast27Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast27X = 5;
                    Ast27Y = 8;
                    grid[Ast27X,Ast27Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast28X && bullet8y == Ast28Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast28X = 4;
                    Ast28Y = 8;
                    grid[Ast28X,Ast28Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast29X && bullet8y == Ast29Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast29X = 3;
                    Ast29Y = 8;
                    grid[Ast29X,Ast29Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast30X && bullet8y == Ast30Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast30X = 2;
                    Ast30Y = 8;
                    grid[Ast16X,Ast16Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast31X && bullet8y == Ast31Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast31X = 1;
                    Ast31Y = 8;
                    grid[Ast31X,Ast31Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }
                                if(bullet8x == Ast32X && bullet8y == Ast32Y)
                {  
                    Console.Beep(250,500);
                    bullet8x = yAxis;
                    bullet8y = xAxis;
                    Ast32X = 0;
                    Ast32Y = 8;
                    grid[Ast32X,Ast32Y] ="  ";
                    Ast2Direction = 0;
                    Ast2 = false;
                    bullet8  = false;
                }                                                                                                
                




                draw();
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Please pick a dificulty \n 1: Practice \n 2: Easy \n 3: Medium \n 4: Hard \n 5: Impossible");
            DifficultyDecision = Console.ReadLine();
            switch (DifficultyDecision)
            {
                case "1":
                    Difficulty = 2;
                    Console.Clear();
                    Console.Write("Your difficuty is set to Tutorial \n Press any key to continue");
                    Console.ReadKey();
                    break;
                case "2":
                    Difficulty = 500;
                    Console.Clear();
                    Console.Write("Your difficuty is set to Easy \n Press any key to continue");
                    Console.ReadKey();
                    break;
                case "3":
                    Difficulty = 250;
                    Console.Clear();
                    Console.Write("Your difficuty is set to Medium \n Press any key to continue");
                    Console.ReadKey();
                    break;
                case "4":
                    Difficulty = 90;
                    Console.Clear();
                    Console.Write("Your difficuty is set to Hard \n Press any key to continue");
                    Console.ReadKey();
                    break;
                case "5":
                    Difficulty = 32;
                    Console.Clear();
                    Console.Write("Your difficuty is set to Impossible \n Press any key to continue");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Incorect number please try again. \n Press any key to continue");
                    Console.ReadKey();
                    break;
            }
            break;
        case "3":
            GameLoop = 1;
            break;
        default:
            Console.WriteLine("Incorect number please try again. \n Press any key to continue");
            Console.ReadKey();
            break;
    }
}

