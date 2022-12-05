int Ast1X = 0;
int Ast1Y = 1;
int Ast1Direction = 0;
bool Ast1 = false;


int Ast2X = 0;
int Ast2Y = 2;
int Ast2Direction = 0;
bool Ast2 = false;

int Ast3X = 0;
int Ast3Y = 3;
int Ast3Direction = 0;
bool Ast3 = false;

int Ast4X = 0;
int Ast4Y = 4;
int Ast4Direction = 0;
bool Ast4 = false;

int Ast5X = 0;
int Ast5Y = 5;
int Ast5Direction = 0;
bool Ast5 = false;

int Ast6X = 0;
int Ast6Y = 6;
int Ast6Direction = 0;
bool Ast6 = false;

int Ast7X = 0;
int Ast7Y = 7;
int Ast7Direction = 0;
bool Ast7 = false;

int Ast8X = 0;
int Ast8Y = 8;
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
int Ast32Y = 0;
int Ast32Direction = 0;
bool Ast32 = false;


string[,] grid = new string[9, 9];
/*void initalizescreen()
{ for(int x; x<) 
g = "  ";
}
Console.Write(grid);*/
void draw()
{

    for (int row = 0; row < grid.GetLength(1); row++)
    {
        for (int column = 0; column < grid.GetLength(1); column++)
            Console.Write(grid[row, column]+ "  ");

        Console.WriteLine();
    }
}
int AstSpawn = 0;
int Direction = 0;
int xAxis = 5;
int yAxis = 5;
int exit = 0;
int playerPosition = 1;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// initalizescreen();
while (exit < 1)
{

    Random rand1 = new Random();
    AstSpawn = rand1.Next(400);
    Random rand2 = new Random();
    Direction = rand2.Next(7);
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
            grid[yAxis, xAxis] = "  ";
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
            if (Ast26== true)
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
    if (Ast5 == true){
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
if (Ast6 == true) {
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
if (Ast7 == true) {
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
if (Ast8 == true) {
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
if (Ast9 == true) {
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
if (Ast10 == true) {
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
if (Ast11 == true) {
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
if (Ast12 == true) {
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
if (Ast13 == true) {
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
if (Ast14 == true) {
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
if (Ast15 == true) {
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
if (Ast16 == true) {
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
if (Ast17 == true) {
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
if (Ast18 == true) {
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
if (Ast19 == true) {
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
if (Ast20 == true) {
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
if (Ast21 == true) {
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
if (Ast22 == true) {
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
if (Ast23 == true) {
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
if (Ast24 == true) {
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
if (Ast25 == true) {
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
if (Ast26 == true) {
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
if (Ast27 == true) {
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
if (Ast28 == true) {
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
if (Ast29 == true) {
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
if (Ast30 == true) {
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
if (Ast31 == true) {
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


draw();
}
/*
    switch(playerPosition)
    {
    case 1:
    AstX--;
    AstY--;
        break;
    case 2:
    AstX--;
    AstY++;
        break;
    case 3:
    AstX++;
    AstY--;
        break;
    case 4:
    AstX++;
    AstY--;
        break;
    case 5:
    AstX--;
        break;
    case 6:
    AstX++;
        break;
    case 7:
    AstY--;
        break;
    case 8:
    AstY++;
        break;
    }
    */

