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
            //Shoots the weapon and plays a sound
            Console.Beep();
            break;
        case ConsoleKey.Escape:
            //Exits the game
        exit++;
            break;
    }
    switch (playerPosition)
    {
        //Each case should have a variable that advances the game one frame
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
// first row 
(string, int)  a1 = ("a",1);
(string, int)  a2 = ("a",1);
(string, int)  a3 = ("a",1);
(string, int)  a4 = ("a",1);
(string, int)  a5 = ("a",1);
(string, int)  a6 = ("a",1);
(string, int)  a7 = ("a",1);
(string, int)  a8 = ("a",1);

// second row
(string, int)  b1 = ("a",1);
(string, int)  b2 = ("a",1);
(string, int)  b3 = ("a",1);
(string, int)  b4 = ("a",1);
(string, int)  b5 = ("a",1);
(string, int)  b6 = ("a",1);
(string, int)  b7 = ("a",1);
(string, int)  b8 = ("a",1);

// third row
(string, int)  c1 = ("a",1);
(string, int)  c2 = ("a",1);
(string, int)  c3 = ("a",1);
(string, int)  c4 = ("a",1);
(string, int)  c5 = ("a",1);
(string, int)  c6 = ("a",1);
(string, int)  c7 = ("a",1);
(string, int)  c8 = ("a",1);

//fourth row
(string, int)  d1 = ("a",1);
(string, int)  d2 = ("a",1);
(string, int)  d3 = ("a",1);
(string, int)  d4 = ("a",1);
(string, int)  d5 = ("a",1);
(string, int)  d6 = ("a",1);
(string, int)  d7 = ("a",1);
(string, int)  d8 = ("a",1);


// fifth row
(string, int)  e1 = ("a",1);
(string, int)  e2 = ("a",1);
(string, int)  e3 = ("a",1);
(string, int)  e4 = ("a",1);
(string, int)  e5 = ("a",1);
(string, int)  e6 = ("a",1);
(string, int)  e7 = ("a",1);
(string, int)  e8 = ("a",1);

//sixth row
(string, int)  f1 = ("a",1);
(string, int)  f2 = ("a",1);
(string, int)  f3 = ("a",1);
(string, int)  f4 = ("a",1);
(string, int)  f5 = ("a",1);
(string, int)  f6 = ("a",1);
(string, int)  f7 = ("a",1);
(string, int)  f8 = ("a",1);

//seventh row
(string, int)  g1 = ("a",1);
(string, int)  g2 = ("a",1);
(string, int)  g3 = ("a",1);
(string, int)  g4 = ("a",1);
(string, int)  g5 = ("a",1);
(string, int)  g6 = ("a",1);
(string, int)  g7 = ("a",1);
(string, int)  g8 = ("a",1);


//eighth row
(string, int)  h1 = ("a",1);
(string, int)  h2 = ("a",1);
(string, int)  h3 = ("a",1);
(string, int)  h4 = ("a",1);
(string, int)  h5 = ("a",1);
(string, int)  h6 = ("a",1);
(string, int)  h7 = ("a",1);
(string, int)  h8 = ("a",1);


