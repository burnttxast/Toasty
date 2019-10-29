using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventure_Game
{
    class Game
    {
        public static void gameTitle()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string TitleText = "";
            TitleText = @"

 ██████╗  █████╗ ███████╗    ███████╗████████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗    
██╔════╝ ██╔══██╗██╔════╝    ██╔════╝╚══██╔══╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║    
██║  ███╗███████║███████╗    ███████╗   ██║   ███████║   ██║   ██║██║   ██║██╔██╗ ██║    
██║   ██║██╔══██║╚════██║    ╚════██║   ██║   ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║    
╚██████╔╝██║  ██║███████║    ███████║   ██║   ██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║    
 ╚═════╝ ╚═╝  ╚═╝╚══════╝    ╚══════╝   ╚═╝   ╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝    
                                                                                          ";

            Console.WriteLine(TitleText);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press 'enter' to start // continue");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            first();
        }
        public static void first()
        {
            string choice;
            Console.WriteLine("It is a dark night and you driving back home from a movie.");
            Console.WriteLine("You already dropped your friend off and you get hungry.");
            Console.WriteLine("You pull over to a gas station park your car and open the door.");
            Console.WriteLine("You see a young anxious girl jump a bit when you open the door.");
            Console.WriteLine("She trips on air and scurries back behind the counter.");
            Console.WriteLine("You try and act like you don't know or care while picking");
            Console.WriteLine("up a bag of chips and soda and place it on the counter.");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Oh hey...");
            Console.WriteLine("What is your name?");
            Player PlayableCharacter = new Player(Console.ReadLine(), "You are the main character.");
            Console.WriteLine("I'm so glad I am not alone anymore.. Nice to meet you " + PlayableCharacter.ReturnName() + ".") ;
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("She seems very hesitant and anxious but you don't mind,");
            Console.WriteLine("you don't plan on staying long.");
            Console.WriteLine("You pay her and she grabs the money and stares.");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Is everything okay...?");
            Console.WriteLine("...");
            Console.ResetColor();
          
            Console.WriteLine("she nods yes and hands you your receipt.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("- (a) Leave this weird place");
            Console.WriteLine("- (b) Ask her more questions");
            Console.ResetColor();

            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();





            switch (choice)
            {

                case "Ask":
                case "b":
                case "Ask her more questions":
                    
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("So what is your name?");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" It doesn't matter.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("(a) Ok whatever freak..."
                    + Environment.NewLine + "(b) Oh.. Sorry.");
                    Console.Write("Choice: ");
                    choice = Console.ReadLine().ToLower();
                    Console.Clear();
                    Console.ResetColor();
                    switch (choice)
                    {

                        case "a":
                        case "ok":
                        case " Ok whatever freak...":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("*She runs into the back room Crying*");
                            break;

                        case "b":
                        case "Oh":
                        case "Oh.. Sorry.":
                            Console.WriteLine("*A tear streams from her eye as she nervously mutters");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("No... I am sorry my name is Danny.");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("You smile an wave leaving and\n heading back to your car.");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(  " Goodby danny!");
                            Console.ResetColor();
                            break;
                    }

                    break;
            }

            {

                Console.WriteLine("You wave and head out to the store " + Environment.NewLine +
                    "closing the door behind you and walk to your car. " + Environment.NewLine +
                    "You get in your car and look up and out of the window.");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("What the freak... ");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You are already at home.There is no way... " + Environment.NewLine +
                    "You didn't even turn on the car yet. " + Environment.NewLine +
                    "You look to where you put your snacks and they are still there next to your keys.");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Okay it is way to late for this....");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You know this is a really weird situation but " + Environment.NewLine +
                    "you are starving and will deal with this in a second. " + Environment.NewLine +
                    "You pop open that bag of chips and that nice soda and go to town.");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ooh yah..That's the good stuff.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("You chuck the trash in the back of the car then go to leave your car and lock it." + Environment.NewLine +
                    "You look up from locking your car door and realize " + Environment.NewLine +
                    "you are back at the gas station again.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You run up to the gas station door and go to open it and" + Environment.NewLine +
                    "realize that girl is there. She is crying and keep repeating she is sorry. " + Environment.NewLine +
                    "You reach for the handle and it is locked." + Environment.NewLine +
                    "She screams and brushes her hair behind her ear and runs behind the counter." + Environment.NewLine +
                    "You notice a large reflection in the glass.");
                Console.WriteLine("- (a) Turn around");
                Console.WriteLine("- (b) Break the glass to get in");
                Console.ResetColor();
                Console.Write("Choice: ");
                choice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (choice)
                {
                    case "a":
                    case "Turn around":
                    case "turn":

                        Console.WriteLine("*A shadow comes over you draping the space around you in darkness." + Environment.NewLine +
                            "You press agent the door and turn around in fear.  " + Environment.NewLine +
                            "Your eyes scale up the beast but his eyes are closed.");
                        Console.ReadLine();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("What the heck... ");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Tears start streaming down your face.\nYou sink to the floor crying.");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("NOOOO NOOOO HELP HELPPPP! \n*He opens his eyes and your body freezes into some kind of trance*");
                        Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        string TitleText = "";
                        TitleText = @"

▓██   ██▓ ▒█████   █    ██      █████▒▄▄▄       ██▓ ██▓    ▓█████ ▓█████▄           
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▓██   ▒▒████▄    ▓██▒▓██▒    ▓█   ▀ ▒██▀ ██▌          
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒████ ░▒██  ▀█▄  ▒██▒▒██░    ▒███   ░██   █▌          
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▒  ░░██▄▄▄▄██ ░██░▒██░    ▒▓█  ▄ ░▓█▄   ▌          
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒█░    ▓█   ▓██▒░██░░██████▒░▒████▒░▒████▓  ██▓  ██▓ 
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒ ░    ▒▒   ▓▒█░░▓  ░ ▒░▓  ░░░ ▒░ ░ ▒▒▓  ▒  ▒▓▒  ▒▓▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░       ▒   ▒▒ ░ ▒ ░░ ░ ▒  ░ ░ ░  ░ ░ ▒  ▒  ░▒   ░▒  
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░     ░   ▒    ▒ ░  ░ ░      ░    ░ ░  ░  ░    ░   
 ░ ░         ░ ░     ░                     ░  ░ ░      ░  ░   ░  ░   ░      ░    ░  
 ░ ░                                                               ░        ░    ░    
                                                                                          ";

                        Console.WriteLine(TitleText);

                        Console.WriteLine("Start Over?");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        first();




                        break;
                    case "b":
                    case "break":
                    case "break the glass":

                        Console.WriteLine("*She screams and runs away.*");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NONONOO STOP! ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("*You get through the glass and she is panicking and tries to hide behind the counter.");
                             Console.WriteLine("You realize it’s not just the two of you as the earth slightly vibrates and\n you hear heavy breathing.You turn around quick enough tough to see\n what you are dealing with and leave." + Environment.NewLine +
                            "You make it for the backroom as you hear the gas station girl screaming" + Environment.NewLine +
                            "but then she follows behind you as you quickly lock the door.*" + Environment.NewLine +
                            "-(a)Ask her what is happening\n- (b)Start looking for things");
                        Console.Write("Choice: ");
                        choice = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choice)
                        {
                            case "a":
                            case "ask":
                            case "Ask her what is happening":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("What is happening here?");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("  That is the mythic beast the keeper of the oil!  \nHe has come back to steal back the oil\n us humans has taken from this land." + Environment.NewLine +
                                    "We need to find out what we need for the ritual to make to get the beast go away but…\nBut what \n?I don’t know where the book is….");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine  (  "-(a)Look in closet- /n(b)Look in desk");
                                Console.ResetColor();
                                Console.Write("Choice: ");
                                choice = Console.ReadLine().ToLower();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "a":
                                    case "Look in closet":
                                        Console.WriteLine("You see A bowl a stone and a lighter but no book...\n you look in the desk.");
                                        break;
                                }
                                break;

                        }
                        Console.WriteLine("*You rummage around and you find a book in the desk*");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("-(a) Read it\n-(b) throw it away");
                        Console.ResetColor();
                        Console.Write("Choice: ");
                        choice = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choice)
                        {
                            case "a":
                            case "read":
                            case "read it":
                                BookRoute();
                                break;
                            case "b":
                            case "throw away":
                            case "throw it away":

                                EndingB();
                                break;
                        }
                        break;
                }
            }
        }

        static void EndingB()
        {
            Console.WriteLine("You don't believe in this magic book stuff. " + Environment.NewLine +
                " You notice she is frantically looking while you are not caring at all, " + Environment.NewLine +
                "and preparing for the worst.  " + Environment.NewLine +
                "All of a sudden the floor begins to shake and the door swings open. " + Environment.NewLine +
                " An ominous black cloud enter the room as the beast burst in.  " + Environment.NewLine +
                "You jump up and yell.. ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("But oddly enough at the same time you are fighting this dark cloth.. " + Environment.NewLine +
                "Wait.. blankets ...? You look around realizing it was only a nightmare…" + Environment.NewLine +
                "You Roll out of bed and go to walk to the basement for some water. " + Environment.NewLine +
                " You open the door and you are back in the gas station again… ");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You did not complete the ritual try again ?");
            Console.ReadKey();
            first();
        }

        static void BookRoute()
        {
            StreamReader sr = new StreamReader("Book.txt");
            String line = sr.ReadToEnd();
            string choice = "";
            Console.WriteLine("You skim the book to find the items you need");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(a) Show Book \n (b) Read Book");
            choice = Console.ReadLine().ToLower();
            Console.ResetColor();
            switch (choice)
            {

                case "a":
                case "Show":
                case "Show Book":
                    Console.WriteLine(line);
                    Console.ReadKey();
                    break;


            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("I got it! You need… " + Environment.NewLine +
                "A  bowl a stone and a lighter! " + Environment.NewLine +
                "Check the closet! ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("She opens the closet and lays the items on the floor and starts the ritual." + Environment.NewLine +
                "The floor the floor shakes and you hear the monster began to yell and then silence  " + Environment.NewLine +
                "You look outside the door slowly and everything is normal.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You wipe your tears and give her a hug. " + Environment.NewLine +
                "You get back into your car and drive home..");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string TitleText = "";
            TitleText = @"
▄██   ▄    ▄██████▄  ███    █▄        ▄█     █▄   ▄█  ███▄▄▄▄   
███   ██▄ ███    ███ ███    ███      ███     ███ ███  ███▀▀▀██▄ 
███▄▄▄███ ███    ███ ███    ███      ███     ███ ███▌ ███   ███ 
▀▀▀▀▀▀███ ███    ███ ███    ███      ███     ███ ███▌ ███   ███ 
▄██   ███ ███    ███ ███    ███      ███     ███ ███▌ ███   ███ 
███   ███ ███    ███ ███    ███      ███     ███ ███  ███   ███ 
███   ███ ███    ███ ███    ███      ███ ▄█▄ ███ ███  ███   ███ 
 ▀█████▀   ▀██████▀  ████████▀        ▀███▀███▀  █▀    ▀█   █▀  
                                                                   ";

            Console.WriteLine(TitleText);
            Console.ReadKey();
        }

    }
}

