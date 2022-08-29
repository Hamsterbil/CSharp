#region Functions

//Steps, but I choose to call function because player walks 3 times
void Step() {
Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)");
    Thread.Sleep(500);
    Console.WriteLine("(]");
    Thread.Sleep(500);
    Console.WriteLine("  [)\n");
    Thread.Sleep(500);
}

//Normal speed typewriter function for NPC's
static void NPC(string text, int time = 50)
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

//Function to clear line on cursor position
static void ClearLine()
{
    int currentLine = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLine);
}
#endregion

#region "Checkpoints"

//Actions menu to choose one of the 3 sections.
Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Write number corresponding with section to begin in\n");
    Console.WriteLine("1: The old man");
    Console.WriteLine("2: Problems with PI");
    Console.WriteLine("3: A game of chance\n");

//Uses goto statements to jump to correct lines.
int startMenu = int.Parse(Console.ReadLine());
if (startMenu == 1) {        
}

else if (startMenu == 2) {
    goto two;    
}

else if (startMenu == 3) {
    goto three;    
}

else {       
}

#endregion

#region Old man
Thread.Sleep(1000);
Console.Clear();

    Game("*You approach an old man sitting by a tree*\n");
    Step();

/*"Yes", "no" loop blueprint
while(true) {
    if (forward == "Yes" || forward "yes") {

        Thread.Sleep(1000);
        Console.Clear();
        break;
    }

    else if (forward == "No" || forward == "no") {

        Thread.Sleep(1000);
        Console.Clear();
        break; or continue; or return;
    }

    else {
        NPC("\nI'm sorry, I don't seem to understand");

        Thread.Sleep(1000);
        Console.Clear();
        continue;
    }
} 
*/

string forward;
while(true) {
    NPC("Are you lost weary traveler?\n");

    forward = Console.ReadLine();

if (forward == "Yes" || forward == "yes") {
    NPC("\nThis forest is meant for brave souls, willing to fight through monsters and bandits.\nThere is a dangerous road ahead. You have been warned...");

    Thread.Sleep(1000);
    Console.Clear();
    break;
}

else if (forward == "No" || forward == "no") {
    NPC("Then you must already know these woods");
    
    Thread.Sleep(1000);
    Console.Clear();
    break;
}

else {
    NPC("\nI'm sorry, I don't seem to understand");

    Thread.Sleep(1000);
    Console.Clear();
    continue;
}
}

while(true) {
    NPC("What is your name, weary traveler?\n");
    string name = Console.ReadLine();

    NPC("\nGreetings, " + name + ". Do you wish to continue your wander?\n");
    forward = Console.ReadLine();

    if (forward == "Yes" || forward == "yes") {
        NPC("\nIt's dangerous to go alone! Take this.\n");
        Thread.Sleep(200);

        Game("*Recieved: SWORD*");
        Thread.Sleep(1000);
        break;
    }

    else if (forward == "No" || forward == "no") {
        NPC("Then leave now and don't look back.");
        
        Console.ReadKey();
        return;
    }

    else {
        NPC("\nI'm sorry, I don't seem to understand");

        Thread.Sleep(1000);
        Console.Clear();

        continue;
    }
}

Console.ReadKey();
#endregion

#region PI

//I think only interesting thing here is the use of Console.SetCursorPosition(); to make faces.
#region Just Dialogue 
two:
Thread.Sleep(1000);
Console.Clear();
    Game("*You venture onwards*\n");
    Step();

    Game("*A flickering light appears in the distance...");
    Game("\nA man seems to be mumbling to himself by a campfire*\n");
Thread.Sleep(1000);
Console.Clear();
    NPC("*mumble* *mumble* ... 3.141... or was it 3.142?\n");    
Thread.Sleep(1500);

//Gives the NPC "life"
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
    NPC("\nthe 5 first decimals to finish my calculation");
    NPC("\n\nDon't ask me why. Do you know the 5 first decimals?\n\n");
Thread.Sleep(500);
#endregion

//Actions menu for player
//MAYBE SWITCH ANSWER TO ARRAY WITH MULTIPLE CHOICE INSTEAD?-------------------------------------------------------------------------------
Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter a number from actions down below:");
    Console.WriteLine("[ 1. 'Yes' ] [ 2. 'No' ] [ 3. Slash him ] [ 4. 'Why?' ]\n");

int actions = Convert.ToInt32(Console.ReadLine());

Thread.Sleep(100);
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;

//Switch to check which action player took.
switch (actions) {
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

//Loop until player writes correct answer. PI = 3.14159
while (true) {
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("");
Console.WriteLine("( O)( O)");
Console.WriteLine("   ___");
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\nPi, with the first 5 decimals is: ");
double piAnswer = double.Parse(Console.ReadLine());

if (piAnswer == 3.14159) {
    NPC("\nHmm that sounds reasonable!");

    Console.SetCursorPosition(0, Console.CursorTop - 6);
    ClearLine();
    Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("  ^   ^");
    Console.SetCursorPosition(0, Console.CursorTop + 6);

    NPC("Thank you stranger.");
    Thread.Sleep(1000);
    break;
}

else {
    NPC("\nNo... That doesn't sound right.");
    Thread.Sleep(1000);
    Console.Clear();

    continue;
}
}

Thread.Sleep(1000);
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
    Console.WriteLine("( O)( O)");
    Console.WriteLine("   ___");
    NPC("\nNow get out of my sight.");

Console.ReadKey();
#endregion

#region Game
three:
Thread.Sleep(1000);
Console.Clear();

    Game("*Confused, you begin to leave... The campfire fades in the distance between the trees*\n");
    Step();
    Game("*A one-eyed snake suddenly comes from behind a tree*\n");

    NPC("\nHey kiddo. If you want to continue, you'll have to play a game of chance with me.");
Thread.Sleep(600);
    NPC("\nThe rules are simple. Write a number between 1 and 5 on this piece of paper without showing me.\n");
Thread.Sleep(600);
    Game("\n*Recieved: PAPER*\n");
Thread.Sleep(600);
    NPC("\nAfterwards, I begin to count to 5, but I can stop whenever I want.\nIf you guess my number you win and can continue.\nOkay?");
Thread.Sleep(600);
    SlowerNPC(" Okay.");

Thread.Sleep(600);
Console.Clear();

/*
Loop guesses until correct. All inside while(guessing) loop.
Starts by checking if player has tried to guess 5 times already. If not, it makes player write on the "paper".
Afterwards it starts counting with for loop and checks if players guess is correct, wrong or if they wrote less/more than 1 or 5.
If they guess correctly, NPC tells how many attempts it took. 
*/
int tries = 0;
int totalTries = 1;
bool guessing = true;
while(guessing) {
    int i;
    Random rnd = new Random();

    if(tries == 5) {
        NPC("It seems you are struggling...\n");

        //Actions menu
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nEnter a number from actions down below:");
        Console.WriteLine("[ 1. Keep going ] [ 2. Slash the snake ] [ 3. Cry ]\n");

        actions = Convert.ToInt32(Console.ReadLine());
        switch(actions) {
            case 1:
                NPC("\nAlright.");

                tries = 0;
                Thread.Sleep(1000);
                Console.Clear();
                break;

            case 2:
                NPC("\nHey hey hey hey!\nWhat are you doing?\n");
                Thread.Sleep(2000);

                Game("\n*You are now a murderer*");
                
                guessing = false;
                Thread.Sleep(2000);
                Console.Clear();
                continue;

            case 3:
                NPC("\nIm not sure how that's helping...");

                Thread.Sleep(1000);
                Console.Clear();
                break;
        }
    }

    Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Write a number between 1 - 5 on your paper\n");
    Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("-----------------");
        Console.WriteLine("|               |");
        Console.WriteLine("|               |");
        Console.WriteLine("|               |");
        Console.WriteLine("-----------------");
    Console.SetCursorPosition(8, 4);
    
    int guess = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(0, 8);

        NPC("Okay, I'll start counting now.\n\n");
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(300);

    for(i = 1; i <= rnd.Next(1,6); i++) {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
    Console.WriteLine("");

        NPC("Let's see");
        SlowerNPC("...\n");
    
    if(i - 1 == guess) {
        if(totalTries == 1) {
            NPC("Whoah you actually guessed it. Only took "+ totalTries +" try.\n");
        }

        else {
            NPC("Whoah you actually guessed it. Only took "+ totalTries +" tries.\n");
        }

        Thread.Sleep(2000);
        Console.Clear();

        break;
    }
    
    else if(guess > 5) {
        NPC("That's not between 1 and 5. Too high.");
        Thread.Sleep(700);
        Console.Clear();

        continue;
    }

    else if(guess <= 0) {
        NPC("That's too low...");
        Thread.Sleep(700);
        Console.Clear();

        continue;
    }

//Increments tries until it reaches 5, then asks if player wants to continue.
//Increments totalTries until player guesses correctly, then returns value to player.
    else {
        NPC("Wrong.");
        tries++;
        totalTries++;
        Thread.Sleep(700);
        Console.Clear();

        continue;
    }
}
    Game("*You leave the one-eyed snake.*");
#endregion

    Step();
    Game("\nAfter a while, you reach the end of the forest. The sun is shining*");

Console.ReadKey();