void TypeWriter(string text, int time = 50)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
}

Console.ForegroundColor = ConsoleColor.White;
TypeWriter("Are you lost weary traveler?\n");
Console.ForegroundColor = ConsoleColor.Red;
string forward = Console.ReadLine();

if (forward == "yes")
{
    Console.ForegroundColor = ConsoleColor.White;
    TypeWriter("This forest is meant for brave travelers, willing to fight monsters and thieves.\n");
    TypeWriter("There is a dangerous road ahead. You have now been warned");

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
    TypeWriter("Greetings, ");
    Console.ForegroundColor = ConsoleColor.Red;
    TypeWriter(name);
    Console.ForegroundColor = ConsoleColor.White;
    TypeWriter(". Do you wish to continue your wander?\n");
    
    Console.ForegroundColor = ConsoleColor.Red;
    forward = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    if (forward == "yes"){        
        TypeWriter("\nIt's dangerous to go alone! Take this.\n");
        Thread.Sleep(200);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        TypeWriter("*Recieved: SWORD*");
        
        Thread.Sleep(1500);
        Console.Clear();
    }
    else{
        Console.ForegroundColor = ConsoleColor.White;
        TypeWriter("Then head back now and never look back.");
    }

Console.ReadKey();
