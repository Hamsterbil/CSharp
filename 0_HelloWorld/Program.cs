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

//Function to clear line on cursor position
void ClearLine()
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
    Console.WriteLine("2: Campfire");
    Console.WriteLine("3: A game of chance\n");

//Uses goto statements to jump to corresponding regions. Only use of "goto" is here.
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

/* "Yes", "no" loop blueprint to copy.
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
string name;
while(true) {
    NPC("What is your name, weary traveler?\n");
    name = Console.ReadLine();

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
//I think only interesting thing during region "Just Dialogue" is the use of Console.SetCursorPosition(); to make faces.
#region Just Dialogue 
two:
Thread.Sleep(1000);
Console.Clear();
    Game("*You venture onwards*\n");
    Step();

    Game("*A flickering light appears in the distance...");
    Game("\nA man seems to be grilling something by a campfire*\n");
Thread.Sleep(1000);
Console.Clear();

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
Console.SetCursorPosition(0, Console.CursorTop - 2);
ClearLine();
Console.SetCursorPosition(0, Console.CursorTop + 4);
Thread.Sleep(1000);

    SlowerNPC("Hello...\n");
Thread.Sleep(300);
    NPC("Who are you?\n");
Thread.Sleep(500);
#endregion

    Console.WriteLine("\nMy name is");
Console.SetCursorPosition(11, Console.CursorTop + -1);
name = Console.ReadLine();

Thread.Sleep(1000);
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n( O )( O )");
    Console.WriteLine("   ___");
    NPC("\nOkay, " + name + ". Can you help me rank the 5 best sentences ever spoken?\n");
Thread.Sleep(500);
    NPC("Yes?\n");
Thread.Sleep(500);
    NPC("Thank you.");
Thread.Sleep(1000);
Console.Clear();

Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n( O )( O )");
    Console.WriteLine("   ___");

//Array for 5 sentences
string[] sentences = new string[5];

Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nWrite and rank the 5 best sentences.");
Console.ForegroundColor = ConsoleColor.Red;

//Loop the length of the array. Number the sentences first, then make player write
for(int i = 0; i < sentences.Length; i++) {
    Console.WriteLine(i + 1 + ". ");
    Console.SetCursorPosition(3, Console.CursorTop - 1);
    sentences[i] = Console.ReadLine();
}

Thread.Sleep(500);
    NPC("\nHmm... good sentences, but I prefer them ranked like this:\n");
Console.ForegroundColor = ConsoleColor.White;

//Randomly order (shuffle) array, and write in console. 
Random random = new Random();
sentences = sentences.OrderBy(x => random.Next()).ToArray();
for(int i = 0; i < sentences.Length; i++) {    
    foreach (var inc in sentences) {
        i++;
        Console.WriteLine(i + ". " + inc);
    }
}
    NPC("\nThese are the best sentences ever spoken in my opinion:\n");
Console.ForegroundColor = ConsoleColor.White;

List<string> stringList = new List<string>();
stringList.Add("To be is to do.\n");
stringList.Add("To do is to be.\n");
stringList.Add("Do be do be do.\n");
stringList.Add("If she leaves you for another... There is always her mother.\n");
stringList.Add("If she isn't blood related, then she is to be dated.\n");

for (int i = 0; i < sentences.Length; i++) {
NPC(i + 1 + ". " + stringList[i]);
Thread.Sleep(300);
}

Console.ReadKey();
#endregion

#region Game
three:
Thread.Sleep(1000);
Console.Clear();

    Game("*Confused, you begin to leave... The campfire fades in the distance between the trees*\n");
    Step();
    Game("*A spaniard suddenly comes from behind a tree*\n");

    NPC("\nHello, my name is Inigo Montoya. I do not mean to pry, but you don't by any chance happen to have six fingers on your right hand?");
Thread.Sleep(1000);
    NPC("\nI see you do not. Do you then care to play a game of chance with me?");
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
        Console.WriteLine("[ 1. Keep going ] [ 2. Slash Inigo Montoya ] [ 3. Cry ]\n");
       
        int actions = Convert.ToInt32(Console.ReadLine());
        switch(actions) {
            case 1:
                NPC("\nAlright.");

                tries = 0;
                Thread.Sleep(1000);
                Console.Clear();
                break;

            case 2:
                NPC("\nYou seem a decent fellow. I hate to kill you.");
                Thread.Sleep(2000);

                Game("\n*You battle it out, yet it ends in a draw*\n");
                
                guessing = false;
                Thread.Sleep(2000);
                Console.Clear();
                continue;

            case 3:
                NPC("\nIm not sure how that's helping...");

                tries = 3;
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

//Loop and write a number, but loops randomly between 1 and 5 times. For the counting process
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
    Game("*You leave Inigo Montoya...*\n");
#endregion

    Step();
    Game("\nAfter a while, you reach the end of the forest. The sun is shining*");

Console.ReadKey();