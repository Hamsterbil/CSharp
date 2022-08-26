#region Functions

//Normal speed typewriter function for NPC's
void NPC(string text, int time = 50)
{
    Console.ForegroundColor = ConsoleColor.White;  
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
    Console.ForegroundColor = ConsoleColor.Red;  
}

//Slower typewriter function for DRAMATIC EFFECT
void SlowerNPC(string text, int time = 500)
{
    Console.ForegroundColor = ConsoleColor.White;  
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
    Console.ForegroundColor = ConsoleColor.Red;  
}

//Typewriter for the game "narrator"
void Game(string text, int time = 50)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
    Console.ForegroundColor = ConsoleColor.Red;    
}

//Slower typewriter function for DRAMATIC EFFECT
void SlowerGame(string text, int time = 500)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
    Console.ForegroundColor = ConsoleColor.Red;    
}

//Function to clear line on cursor position
static void ClearLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}

#endregion

//TEST AREA:

//goto test;

//----------

#region Old man
    Game("*You approach an old man sitting by a tree*\n");
//Steps
Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)");
    Thread.Sleep(500);
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)\n");
    Thread.Sleep(500);

    NPC("Are you lost weary traveler?\n");

    string forward = Console.ReadLine();

if (forward == "Yes")
{
    NPC("\nThis forest is meant for brave souls, willing to fight through monsters and bandits.\nThere is a dangerous road ahead. You have been warned...");

    Thread.Sleep(1500);
    Console.Clear();
}

else
{
    NPC("Then you must already know these woods");
    
    Thread.Sleep(1500);
    Console.Clear();
}

NPC("What is your name, weary traveler?\n");
string name = Console.ReadLine();

NPC("Greetings, " + name + ". Do you wish to continue your wander?\n");
forward = Console.ReadLine();

if (forward == "Yes")
{
    NPC("\nIt's dangerous to go alone! Take this.\n");
    Thread.Sleep(200);

    Game("*Recieved: SWORD*");
    Thread.Sleep(1500);
}

else
{
    NPC("Then leave now and don't look back.");
    
    Console.ReadKey();
    return;
}

Console.ReadKey();
Console.Clear();

#endregion

#region PI
Game("*You venture onwards*\n");
Console.ForegroundColor = ConsoleColor.DarkGray;
//Steps
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)");
    Thread.Sleep(500);
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)\n");
    Thread.Sleep(500);

Game("*A flickering light appears in the distance");
SlowerGame("....");
Game("\nA man seems to be mumbling to himself by a campfire*\n");

Thread.Sleep(1000);
Console.Clear();

NPC("*mumble* *mumble* ... 3.141... or was it 3.142?\n");
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" \\   /");
    Console.WriteLine("( O)( O)");
    Console.WriteLine("   ___");
Thread.Sleep(1000);

Console.SetCursorPosition(0, Console.CursorTop - 2);
ClearLine();
    Console.WriteLine("(O )(O )");
Thread.Sleep(1000);

Console.SetCursorPosition(0, Console.CursorTop - 1);
ClearLine();
Console.SetCursorPosition(0, Console.CursorTop - 1);
ClearLine();
    Console.WriteLine("");
    Console.WriteLine("( O )( O )");
Console.SetCursorPosition(0, Console.CursorTop - 3);
ClearLine();
Console.SetCursorPosition(0, Console.CursorTop + 5);
Thread.Sleep(1000);

NPC("Hello...");
Thread.Sleep(300);
NPC("\nI seem to have forgotten the decimals of PI, and I");

Console.ForegroundColor = ConsoleColor.White;
Console.SetCursorPosition(0, Console.CursorTop - 5);
    Console.WriteLine(" \\   /");
Console.SetCursorPosition(0, Console.CursorTop + 5);
Thread.Sleep(1000);

SlowerNPC("NEED");
NPC("\nthe 10 first decimals to finish my calculation");
NPC("\n\nDon't ask me why. Do you know the 5 first digits?\n\n");
Thread.Sleep(500);

//Actions menu for player
Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter a number from actions down below:");
    Console.WriteLine("[ 1. 'Yes' ] [ 2. 'No' ] [ 3. Slash him ] [ 4. 'Why?' ]\n");

int actions = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
switch (actions)
{
    case 1:
        Console.SetCursorPosition(0, Console.CursorTop + 2);
        Console.WriteLine("( o )( O )");
        Console.WriteLine("   ___");
        Thread.Sleep(1000);

        NPC("\nOh!");
        Thread.Sleep(1000);
        NPC("\nPlease do tell.");
        break;

    case 2:
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine("( . )( . )");
        Console.WriteLine("   ___");
        Thread.Sleep(1000);

        NPC("\nThen why are you here...");
        Thread.Sleep(1000);
        NPC("\nI still want to see you try");
        break;

    case 3:
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine(".-.");
        Thread.Sleep(1000);

        NPC("\nDude...");
        Thread.Sleep(1000);
        NPC("\nDo you think this is some kind of RPG??");
        Thread.Sleep(1000);

        NPC("\nGet your act together and tell me the 5 first decimals of pi.");
        break;

    case 4:
        Console.WriteLine(" \\   /");
        Console.WriteLine("( O)( O)");
        Console.WriteLine("   ___");
        Thread.Sleep(1000);

        NPC("\nI SAID DON'T ASK");
        SlowerNPC("...");
        NPC(" But thank you for showing interest");
        Thread.Sleep(1000);

        NPC("\nNow tell me the 5 first decimals of pi.");
        break;
}
Thread.Sleep(1000);
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("");
Console.WriteLine("( O)( O)");
Console.WriteLine("   ___");
Thread.Sleep(1000);

//PI = 3.14159
double pie = Math.PI;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nPi, with the first 5 decimals is: ");
double piAnswer = double.Parse(Console.ReadLine());

#endregion

//Next encounter: Guessing game. Guess a number between 0-10 and npc counts until random number which breaks loop. If player guesses correct, pass, otherwise loop

Console.ReadKey();