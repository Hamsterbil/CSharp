void TypeWriter(string text, int time = 50)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
void SlowerWriter(string text, int time = 500)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}
static void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}

//TEST AREA:

//goto test;

//

#region old man
Console.ForegroundColor = ConsoleColor.DarkGray;
TypeWriter("*You approach an old man sitting by a tree*\n");
Console.WriteLine("(]");
Thread.Sleep(500);
Console.WriteLine("  [)");
Thread.Sleep(500);
Console.WriteLine("(]");
Thread.Sleep(500);
Console.WriteLine("  [)\n");
Thread.Sleep(500);

Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Are you lost weary traveler?\n");
Console.ForegroundColor = ConsoleColor.Red;
string forward = Console.ReadLine();

if (forward == "yes")
{
    Console.ForegroundColor = ConsoleColor.White;
    TypeWriter(
        "\nThis forest is meant for brave souls, willing to fight through monsters and bandits.\n"
    );
    TypeWriter("There is a dangerous road ahead. You have been warned...");

    Thread.Sleep(1500);
    Console.Clear();
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
    TypeWriter("Then you must already know these woods");
    Thread.Sleep(1500);
    Console.Clear();
}
TypeWriter("May I ask your name?\n");
Console.ForegroundColor = ConsoleColor.Red;
string name = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Greetings, " + name + ". Do you wish to continue your wander?\n");

Console.ForegroundColor = ConsoleColor.Red;
forward = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;

if (forward == "yes")
{
    TypeWriter("\nIt's dangerous to go alone! Take this.\n");
    Thread.Sleep(200);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    TypeWriter("*Recieved: SWORD*");

    Thread.Sleep(1500);
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
    TypeWriter("Then leave now and don't look back.");
    Console.ReadKey();
    return;
}
Console.ReadKey();
Console.Clear();
#endregion

#region pi

Console.ForegroundColor = ConsoleColor.DarkGray;
TypeWriter("*You venture onwards*\n");
Console.WriteLine("(]");
Thread.Sleep(500);
Console.WriteLine("  [)");
Thread.Sleep(500);
Console.WriteLine("(]");
Thread.Sleep(500);
Console.WriteLine("  [)\n");
Thread.Sleep(500);

TypeWriter("*A flickering light appears in the distance");
SlowerWriter("....");
TypeWriter("\nA man seems to be mumbling to himself by a campfire*");
Console.ReadKey();
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
//test:
//PI = 3.1415926535897931
TypeWriter("*mumble* *mumble* ... 3.141... or was it 3.142?\n");
Thread.Sleep(1500);

Console.WriteLine(" \\   /");
Console.WriteLine("( O)( O)");
Console.WriteLine("   ___");
Thread.Sleep(1000);

Console.SetCursorPosition(0, Console.CursorTop - 2);
ClearCurrentConsoleLine();
Console.WriteLine("(O )(O )");
Thread.Sleep(1000);

Console.SetCursorPosition(0, Console.CursorTop - 1);
ClearCurrentConsoleLine();
Console.SetCursorPosition(0, Console.CursorTop - 1);
ClearCurrentConsoleLine();
Console.WriteLine("");
Console.WriteLine("( O )( O )");
Console.SetCursorPosition(0, Console.CursorTop - 3);
ClearCurrentConsoleLine();
Console.SetCursorPosition(0, Console.CursorTop + 5);
Thread.Sleep(1000);

TypeWriter("Hello...");
Thread.Sleep(300);
TypeWriter("\nI seem to have forgotten the decimals of PI, and I");

Console.SetCursorPosition(0, Console.CursorTop - 5);
Console.WriteLine(" \\   /");
Console.SetCursorPosition(0, Console.CursorTop + 5);
Thread.Sleep(1000);

SlowerWriter("NEED");
TypeWriter("\nthe 10 first decimals to finish my calculation");
TypeWriter("\n\nDon't ask me why. Do you know the 10 first digits?\n\n");
Thread.Sleep(1000);

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

        TypeWriter("\nOh!");
        Thread.Sleep(1000);
        TypeWriter("\nPlease do tell.");

        break;

    case 2:
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine("( . )( . )");
        Console.WriteLine("   ___");
        Thread.Sleep(1000);

        TypeWriter("\nThen why are you here...");
        Thread.Sleep(1000);
        TypeWriter("\nI still want to see you try");

        break;

    case 3:
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        Console.WriteLine(".-.");
        Thread.Sleep(1000);

        TypeWriter("\nDude...");
        Thread.Sleep(1000);
        TypeWriter("\nDo you think this is some kind of RPG??");
        Thread.Sleep(1000);

        TypeWriter("\nGet your act together and tell me the 10 first decimals of pi.");

        break;

    case 4:
        Console.WriteLine(" \\   /");
        Console.WriteLine("( O)( O)");
        Console.WriteLine("   ___");
        Thread.Sleep(1000);

        TypeWriter("\nI SAID DON'T ASK");
        SlowerWriter("...");
        TypeWriter(" But thank you for showing interest");
        Thread.Sleep(1000);

        TypeWriter("\nNow tell me the 10 first decimals of pi.");

        break;
}
Console.ReadKey();
Console.Clear();

Console.WriteLine("( O)( O)");
Console.WriteLine("   ___");
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Red;

TypeWriter("\nIt is: ");
double pi = double.Parse(Console.ReadLine());


#endregion

Console.ReadKey();
