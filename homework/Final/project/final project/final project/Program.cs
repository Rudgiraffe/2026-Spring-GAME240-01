

class Program
{
    enum GameState
    {
        BreakRoom,
        Bathroom,
        QuintonsOffice,
        MainOffice,
        LockerRoom,
        ServerRoom,
        Opening,
    }


    //function for characters appearing one by one and/or colour changes
    static void write(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }

        Console.WriteLine();
    }

    static void coffee(string text)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        
        Console.WriteLine();
    }

    static void writeplayer(string text)
    {
        Console.ForegroundColor = ConsoleColor.White;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        
        Console.WriteLine();
    }


    //I coded the beginning terribly so I had to make this into a function
    //we're all going to collectively ignore it because it works and also the rest of the game is coded fine
    static bool atotcII(int aretheyontheofficecomputer, bool HaveTheyreademails)
    {
        while (aretheyontheofficecomputer == 2)
        {
            bool validChoice = false;

            while (validChoice == false)
            {
                write("Flimsy cubicle walls surround you. The only exit is on your left.");

                string openinganswer = Console.ReadLine().ToLower();

                if (openinganswer == "go left" || openinganswer == "left")
                {
                    write("You stand up, gripping the top of the cubicle wall to assist you. You push yourself leftwards.");

                    validChoice = true;
                    aretheyontheofficecomputer = 99;
                }

                else if (openinganswer == "pick up house plant")
                {
                    writeplayer("You don’t know why, but something compels you to pick up the house plant sat on your desk." +
                                " The experience of shoving it into your pocket is uncomfortable. But you feel safe now." +
                                " You have a house plant.");
                }

                else
                {
                    write("You can't achieve whatever goal your heart truly desires right now." +
                          " Please pick one approved by corporate.");
                }
            }
        }

        return true;
    }


    //and it begins...
    static void Main()
    {
        //misc. variables that I'll need later
        bool HaveTheyreademails = false;
        int aretheyontheofficecomputer = 0;

        //opening segment
        GameState currentRoom = GameState.Opening;
        bool playing = true;

        //prevents the main office intro repeating every loop
        bool mainOfficeIntroPlayed = false;

        write("You sit at your desk. Flimsy cubicle walls surround you. The only opening lays to your left." +
              "\nYour space is empty. The only decoration a small, dying house plant pressed against the " +
              "corner of your desktop computer. \nDo you want to turn on the computer? ");

        string computer;
        computer = Console.ReadLine().ToLower();

        if (computer == "yes")
        {
            aretheyontheofficecomputer = 1;
        }

        else if (computer == "no")
        {
            aretheyontheofficecomputer = 2;
        }

        else
        {
            write("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");
        }

        bool escapeopening = false;

        escapeopening = atotcII(aretheyontheofficecomputer, HaveTheyreademails);

        if (escapeopening == true)
        {
            currentRoom = GameState.MainOffice;
        }


        while (aretheyontheofficecomputer == 1)
        {
            int placeoncomputer = 0;

            while (placeoncomputer == 0)
            {
                write("The computer screen glows. The only applications on the computer are Outlook and Excel. " +
                      "Corporate had gotten the idea a few years ago to strip ‘distractions’ from the workplace " +
                      "through taking stricter admin control of the office computer. God, you had been at this place too long." +
                      "\nWhich application would you like to open? (Or type exit to close the computer). ");

                string applicationchoice = Console.ReadLine().ToLower();

                if (applicationchoice == "exit")
                {
                    placeoncomputer = 3;
                }

                else if (applicationchoice == "excel")
                {
                    placeoncomputer = 2;
                }

                else if (applicationchoice == "outlook")
                {
                    placeoncomputer = 1;
                }

                else
                {
                    write("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");
                    placeoncomputer = 0;
                }
            }


            while (placeoncomputer == 1)
            {
                write("You have two unread emails perched atop the mess that is your inbox…");

                Console.ForegroundColor = ConsoleColor.Yellow;
                write("\nHey Samantha, \n");

                Console.ForegroundColor = ConsoleColor.White;
                write("Ugh, God. It’s from your boss.\n ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                write("It was great seeing you at last weeks meeting.");

                Console.ForegroundColor = ConsoleColor.White;
                write("\nYou were, in fact, NOT at last weeks meeting.\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                write("I was wondering if you might get round to fixing the coffee machine today." +
                      " The coffee’s been tasting weird for a while and for the life of me I can’t figure out what’s " +
                      "wrong with it. \nBest Wishes, \nQuinton Lake\n");

                Console.ForegroundColor = ConsoleColor.White;

                write("Next one is… Oh look, A helpful email from the creator of the game.\n");

                Console.ForegroundColor = ConsoleColor.Magenta;

                write("Hey Player! \nWelcome to Office Space. You’ll find the basic commands you can use to control the game written below:");

                Console.WriteLine(
                    "\nGo… - Fill in this gap with up, right, left, or down." +
                    "\nLook at… - insert an object mentioned in the narration for more information on it." +
                    "\nPick up … - insert an object from the narration to add it to your inventory." +
                    "\nHelp - this will pull up this email again!" +
                    "\nIf you find a computer around the office type turn on computer to interact with it. When done type exit.");

                write("\nI hope you have fun playing this game. If you yell into the void at me, I might reply. \nMuch love, \nJessica <3 )");

                Console.ForegroundColor = ConsoleColor.White;

                write("\nYou close Outlook.");

                HaveTheyreademails = true;
                placeoncomputer = 0;
            }
            


            while (placeoncomputer == 2)
            {
                writeplayer("It’s… ok, it’s empty. But you swear you have a good reason as to why you have done " +
                            "no work in the last week… \nYou can’t remember the reason. But maybe it will come back " +
                            "to you later.");

                placeoncomputer = 0;
            }


            while (placeoncomputer == 3)
            {
                writeplayer("The computer screen flickers off.");

                placeoncomputer = 4;
                aretheyontheofficecomputer = 2;
            }

            escapeopening = atotcII(aretheyontheofficecomputer, HaveTheyreademails);
            
        
            if (escapeopening == true)
            {
                currentRoom = GameState.MainOffice;
            }
        }
//variables
        string choice = "";
        bool havecoffee = false;
        bool chelseashirt = false;
        bool firsttimewithcoffee = true;
        bool haveknife = false;
        bool breakroomfirsttime = true;
        bool bathroomfirsttime = true;
        bool serverroomfirsttime = true;
        bool lockerroomfirsttime = true;
        bool power = true;
        bool paper = false;
        
        
        while (playing)
        {

            Console.WriteLine();

            switch (currentRoom)
            {

                case GameState.MainOffice:
                    

                    //main office intro
                    if (mainOfficeIntroPlayed == false)
                    {
                        writeplayer("The main office space. Your own cubicle lays in a quad of three others at the centre " +
                                    "of the medium sized room (cubicle 1, cubicle 2, cubicle 3, my cubicle). \nThe walls are beige. " +
                                    "The floor is beige. You’re ninety " +
                                    "percent sure the lights are beige too. \nA singular door is placed in the centre of every wall. " +
                                    "There are four walls. Because it is a room. That is how rooms work.");

                        write("You didn’t notice it before but the office is strangely silent. " +
                              "There is absolutely no-one around. Was it a holiday you weren’t made aware of.");
                        if (HaveTheyreademails == true)
                        {
                            write("Either way, you should probably do what Sam asked and fix the coffee machine. " +
                                  "The door to the break room is up from where you stand.");
                        }

                        mainOfficeIntroPlayed = true;
                    }

                    

                    else if (mainOfficeIntroPlayed == true && firsttimewithcoffee == true && havecoffee == true)
                    {
                        writeplayer("The main office space. Your own cubicle lays in a quad of three others at the centre" +
                                    " of the medium sized room.  \nThe walls are beige. The floor is beige. You’re ninety " +
                                    "percent sure the lights are beige too. A singular door is placed in the centre of every " +
                                    "wall. There are four walls. Because it is a room. That is how rooms work.");
                        coffee("\nNot all rooms are square. ");
                        writeplayer("\nYou cast your mind back to the many times you have encountered rooms in your lifetime. " +
                                    "You cannot recall a time where you have been in a room that wasn’t a square. The coffee must be wrong. ");
                        coffee("\nWell, I lived in a circle.");
                        writeplayer("\nThe coffee is lying. ");
                        firsttimewithcoffee = false;
                    }

                    else 
                    {
                        writeplayer("The main office space.");
                    }

                    //movement
                    choice = Console.ReadLine().ToLower();

                    if (choice == "up" || choice == "go up")
                        currentRoom = GameState.BreakRoom;

                    else if (choice == "left" || choice == "go left")
                        currentRoom = GameState.QuintonsOffice;

                    else if (choice == "right" || choice == "go right")
                        currentRoom = GameState.LockerRoom;

                    else if (choice == "down" || choice == "go down")
                        currentRoom = GameState.ServerRoom;
                    
                    //cubicle 1
                    else if (choice == "look at cubicle 1")
                    {
                        writeplayer("This cubicle is filled with football paraphernalia; A Chelsea FC shirt hangs over " +
                                    "the exterior wall, several signed cards are stuck to the side of his computer screen," +
                                    " and a framed photo of himself and John Terry (whom you know the name of through several " +
                                    "rounds of ease dropping) sits on the desk. The cubicle belongs to John.");
                        if (havecoffee == true)
                        {
                            coffee("The hell is football? ");
                            writeplayer("The coffee has a very strange collection of knowledge. It’s almost as if it " +
                                        "knows exactly what would be relevant to the plot, and conveniently doesn’t know" +
                                        " things when it would be funnier not to. That is assuming this small adventure " +
                                        "has a plot. It’s always nice to think your life is part of some sweeping storyline. ");
                            coffee("First off, a ‘sweeping storyline’ in an office? Yeah right. Secondly, my knowledge " +
                                   "base is totally genuine and not at all me getting bored. ");
                            writeplayer("You’re not sure you believe it.");
                            coffee("Believe what you want, idiot.");
                        }
                    }
                    else if (choice == "look at chelsea shirt" || choice == "look at shirt" ||
                             choice == "look at chelsea fc shirt")
                    {
                        writeplayer("It’s a shirt. It looks shirt like. It also has a number on the back. Wild.");
                        if (havecoffee == true)
                        {
                            coffee("Wild indeed.");
                        }
                    }
                    else if (choice == "pick up chelsea shirt" || choice == "pick up shirt" ||
                             choice == "pick up chelsea fc shirt")
                    {
                        writeplayer("That’s, um… right, sure. Do you want to put it on?");
                        string chelsea = Console.ReadLine().ToLower();
                        if (chelsea == "yes")
                        {
                            chelseashirt = true;
                            writeplayer("You slip it over your head. It’s slightly too large for you. You do look snazzy though.");

                            if (havecoffee == true)
                            {
                                coffee("Very good looking.");
                                writeplayer("Your chest feels warm from the compliment.");
                            }

                        }
                        else if (chelsea == "no")
                        {
                            chelseashirt = false;
                            writeplayer("You carefully put the top back down. It’s too cool for you. You wouldn’t want to mess it up. ");

                            if (havecoffee == true)
                            {
                                coffee("*Sigh* sadly, I think you might be right.");
                            }
                        }
                        else
                        {
                            writeplayer("Your brain buffers and you back away from the shirt.");
                        }
                        
                    }
                    else if (choice == "look at picture frame" || choice == "look at picture" ||
                             choice == "look at framed picture")
                    {
                        writeplayer("It’s John and John. ");
                    }
                    else if (choice == "pick up picture frame" || choice == "pick up picture" ||
                             choice == "pick up framed picture")
                    {
                        writeplayer("You stare at the photo for a second then decied against it. The glass in the frame " +
                                    "is immaculate; you wouldn’t want to smudge it.");
                    }
                    
                    //cubicle 2
                    else if (choice == "look at cubicle 2")
                    {
                        writeplayer("This one is even more empty than yours. A single letter opener sits on the desk, " +
                                    "along with a piece of paper. It must belong to Zach.");
                        if (havecoffee == true)
                        {
                            coffee("This one looks sad.");
                            writeplayer("Zach is a very organised person. You noticed that about it and admired him for that. ");
                            coffee("There’s a difference between organised and barren.");
                        }
                    }
                    else if (choice == "look at letter opener")
                    {
                        writeplayer("The letter opener glistens in the overhead lights. It looks cheap but sharp. " +
                                    "Zach clearly kept it in good condition.");
                    }
                    else if (choice == "pick up letter opener")
                    {
                        writeplayer("You slip the small knife into your pocket.");
                        haveknife = true;
                    }
                    
                    //cubicle 3
                    else if (choice == "look at cubicle 3")
                    {
                        writeplayer("This cubicle is filthy. Piles of trash are shoved into the corners of the desk. " +
                                    "A piece of paper sits surprisingly cleanly in the centre of the workspace. " +
                                    "This place is Daniel’s. ");
                    }
                    else if (choice == "look at piles of trash" || choice == "look at piles of trash" || choice == "look at trash")
                    {
                        writeplayer("crisp wrappers and old coke cans form mounds that a pencil sized person would not want " +
                                    "to scale, no matter how risk seeking. ");
                    }
                    else if (choice == "pick up of trash" || choice == "pick up piles of trash" || choice == "pick up trash")
                    {
                        writeplayer("Ew. No");
                        if (havecoffee == true)
                        {
                            coffee("Hard agree.");
                        }
                    }
                    else if (choice == "look at paper")
                    {
                        writeplayer("The paper has ‘Pay Roll’ printed along the top. This can’t be good. " +
                                    "How on earth did Daniel get his hands on this? No-one but Zach and Quinton should " +
                                    "be able to access this. Was it leaked?");
                        if (havecoffee == true)
                        {
                            coffee("Drama at the office? ");
                            writeplayer("Very much so.");
                            coffee("The list proceeds as such: 1. Quinton, 2.Zach, 3.Daniel, 4.John, 5.You.");
                        }

                        paper = true;
                    }
                    else if (choice == "pick up paper")
                    {
                        writeplayer("You don’t think this would be particularly useful to bring with. " +
                                    "It’s just a piece of paper. It might be helpful to look at though.");
                    }
                    
                    //cubicle 4
                    else if (choice == "look at cubicle 4")
                    {
                        writeplayer("No point going back in there.");
                    }
                    
                    // invalid input
                    else
                        Console.WriteLine("You can't achieve whatever goal your heart truly desires right now. " +
                                          "Please pick one approved by corporate.");

                    break;


                case GameState.BreakRoom:

                    //movement

                    if (breakroomfirsttime == false)
                    {
                        writeplayer("The break room.");
                    }
                    if (breakroomfirsttime == true)
                {
                    writeplayer("The break room is a small room with a large decal of a smiling dolphin plastered to the" +
                                " wall. Someone has drawn a penis near its tail. You do not think that is how dolphin anatomy " +
                                "works, but you do not know for certain. You are not a marine biologist. \nA counter " +
                                "stretches the length of the far wall, along with a fridge. On the counter is a coffee " +
                                "machine. \nThe are doors in the room, one to your right, and one behind you. ");
                    breakroomfirsttime = false;
                }
                    choice = Console.ReadLine().ToLower();
                    
                   if (choice == "look at fridge")
                   {
                       writeplayer(
                           "Inside the fridge is an old, half-eaten, birthday cake. It reads; ‘Merry Birthday to " +
                           "our Only Boss’. The icing is blue, which you know for a fact is Quinton’s third least " +
                           "favourite colour. ");
                   }
                   else if (choice == "look at counter")
                        {
                            writeplayer("It’s a kitchen counter. It’s kind of dirty. ");
                        }
                   else if (choice == "look at coffee machine")
                   {
                       writeplayer("It looks like a typical drip coffee machine. Like one you would see in a diner. Or a " +
                                   "film set for a diner. The pot is full. There is nothing obviously wrong with it. ");
                       if (HaveTheyreademails == true)
                       {
                           writeplayer("Quinton said the coffee tasted strange. Maybe you should try it to be sure?");
                       }
                       writeplayer("Do you want to drink the coffee?");
                       string elizabeth = Console.ReadLine().ToLower();
                       if (elizabeth == "no")
                       {
                           writeplayer("Ok.");
                       }
                       else if (elizabeth == "yes")
                       {
                           writeplayer("You pick up the jug from underneath the drip and bring your lips to the side of it. " +
                                       "The coffee… \nIt doesn’t taste bad. Strange was probably the correct word. It " +
                                       "seemed to have a slight chemical undertone. Like if you were to drink drain cleaner. ");
                           coffee("\nHow do you know what drain cleaner tastes like? ");
                           writeplayer("\nWell, you don’t know for sure, but you can guess from the smell.\nWait. Hang on. " +
                                       "You don’t tend to question your own internal monologue. Self-reflection was slightly " +
                                       "past your current place on the pay role. ");
                           coffee("\nIt may not be ‘self’ but it’s definitely some kind of reflection. Everything is. " +
                                  "Light bounces off of shit and that’s how we perceive it. ");
                           writeplayer("\nBut you’re not perceiving ‘it.’ Whatever ‘it’ is. ");
                           coffee("\nAlright then, I’m perceiving you. Same difference.");
                           writeplayer("\nMaybe your time alone in the office has led to some level of enlightenment. You " +
                                       "can now perceive your own sense of self. Your thoughts have presence like text slowly " +
                                       "scrolling across a computer screen.");
                           coffee("\nDon’t be an idiot. I’m the coffee you just drank.");
                           writeplayer("\nIf the only difference between regular coffee and this coffee was the chemical taste," +
                                       " then you can probably attest the other difference between the two – the talking – to that too. ");
                           coffee("\nA real genius, this one.");
                           writeplayer("\nSo, this being is the chemical taste? Someone drugged your coffee? ");
                           coffee("\nNo, don’t be ridiculous. No one would bother drugging your coffee. They were trying " +
                                  "to drug the whole office. And by the looks of it, they succeeded. ");
                           writeplayer("\nOh god, they must have died!");
                           coffee("\nNo, they’ve just been incorporated into the hive mind. Like beans ground into dust " +
                                  "and put in a singular bag.");
                           writeplayer("\nBut you drunk the coffee too.");
                           coffee("\nYou did.");
                           writeplayer("\nBut you don’t feel part of a hive mind. How does someone go about feeling that? " +
                                       "You imagine it must be like the experience of being a toe. But you’ve never been just " +
                                       "a toe, so you don’t know for sure. ");
                           coffee("\nYou’re not far off.");
                           writeplayer("\nThis thing is going to kill you. You know it. Like you know the word for ‘pen’ and " +
                                       "how to place one foot in front of another.");
                           coffee("\nI’m not going to kill you.");
                           writeplayer("\nIt sounds exasperated.");
                           coffee("\nThat’s because I am. Kid, I’m here to help you. Or, well ok, I acquiesce that I’m not" +
                                  " inherently here to help you. In fact, I was sent here to take over you. But I like you. " +
                                  "I think we could be friends. So, in exchange for life long companionship, I’m gonna help " +
                                  "you save your friends.");
                           writeplayer("\nYou don't have any friends.");
                           coffee("\nCo-workers then.");
                           writeplayer("\nYou’re not sure you have any other choice but to let the entity help you.");
                           coffee("You’ve got that right. You need to get into your bosses office. They’re running the " +
                                  "whole thing out of there. ");
                           havecoffee = true;
                       }
                       else
                       {
                           writeplayer("Your brain stutters and you back away from the coffee machine.");
                       }
                   
               }

                    

                    if (choice == "down" || choice == "go down")
                        currentRoom = GameState.MainOffice;

                    else if (choice == "right" || choice == "go right")
                        currentRoom = GameState.Bathroom;

                    else
                        Console.WriteLine("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");

                    break;


                case GameState.Bathroom:

                    //movement
                    if (bathroomfirsttime == false)
                    {
                        writeplayer("The bathroom.");
                    }
                    else if (bathroomfirsttime == true)
                    {
                        writeplayer("You open the door to reveal a small room adorned with a sink accompanied by a small" +
                                    " box of toiletry products, a paper towel dispenser with a message scrawled on it, " +
                                    "and a toilet. This must be a bathroom. ");
                        if (havecoffee == true)
                        {
                            coffee("\nYou reckon?");
                            writeplayer("\nYou don’t think the entity meant this genuinely, and are coming to the " +
                                        "conclusion that this coffee thing is rather mean.");
                            
                        }
                        bathroomfirsttime = false;
                    }

                    choice = Console.ReadLine().ToLower();

                    if (choice == "left" || choice == "go left")
                        currentRoom = GameState.BreakRoom;
                    
                    else if (choice == "look at toiletry products")
                    {
                        writeplayer("A small box of tampons sits on the sink. You find this strange since you are the only woman in the office. It must be an HR requirement. ");
                        if (havecoffee == true)
                        {
                            coffee("\nSo, how do those work? ");
                            writeplayer("\nPure confusion fills your brain.");
                            coffee("\nOh come on, I’ve never had a body before. What are the cotton sticks for? ");
                            writeplayer("\nYou are not answering that.");
                            coffee("\nSpoil sport.");
                        }
                    }
                    
                    else if (choice == "look at toilet")
                    {
                        writeplayer("It’s a toilet. The seat is up. It doesn’t look… great. ");
                        if (havecoffee == true)
                        {
                            coffee("Sure doesn't.");
                        }
                    }
                    
                    else if (choice == "paper towel dispenser" || choice == "look at paper towel" || choice == "look at dispenser")
                    {
                        writeplayer("It’s old, banged up and empty. A message is scratched into the side of it “Fuck " +
                                    "David, he’s paid more than me,” with several dollar signs etched next to the words.");
                        if (havecoffee == true)
                        {
                            coffee("\nYou know him?");
                            writeplayer("\nDid you? Sure, you passed him in the corridors, you watched him stand around " +
                                        "the break room with the rest of your co-workers, but you struggle to remember " +
                                        "a time when you actually talked to him. He was one of the group – the men – you, " +
                                        "distinctly, are not. ");
                            coffee("\nDo you ever think about anything not depressing? It’s like sharing a brain with a teenage boy.");
                        }
                    }

                    else
                        Console.WriteLine("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");

                    break;
                


                case GameState.LockerRoom:

                    //movement
                    if (lockerroomfirsttime == false)
                    {
                        writeplayer("The locker room.");
                    }
                    else if (lockerroomfirsttime == true)
                    {
                        writeplayer("It’s the locker room. A medium sized space lined with rectangular cubes that " +
                                    "contain personal affects or those who work within the larger office space. There are " +
                                    "four lockers (locker 1, locker 2, locker 3). The only exit lays to the left. ");
                        if (havecoffee == true)
                        {
                            coffee("\nWhat’s in your locker? ");
                            writeplayer("\nYou think about the question. You tend to keep a spare house plant in your " +
                                        "locker just in case the other one is taken.");
                            coffee("\nA spare… you know what? I’m not even going to ask. You continue to astound me.");
                            writeplayer("\nYou hope the coffee meant that in a positive way.");
                            coffee("\nI did not.");
                        }
                        lockerroomfirsttime = false;
                    }
                    

                    choice = Console.ReadLine().ToLower();
                    

                    if (choice == "left" || choice == "go left")
                        currentRoom = GameState.MainOffice;
                    
                    
                    else if (choice == "look at locker 1")
                    {
                        if (power == true)
                        {
                            writeplayer("An electronic lock clamps itself to the front of the locker. You'll have to find a way to turn the power off.");
                            if (havecoffee == true)
                            {
                                coffee("\nGreat. Another step. Why is this office so confusing?");
                                writeplayer("\nYou have no idea.");
                            }
                        }

                        if (power == false)
                        {
                            writeplayer(
                                "Neat and tidy - Zach’s Locker. It feels like a crime to even touch it. You slowly " +
                                "back away.");
                            if (havecoffee == true)
                            {
                                coffee("\nToo good for trash like you.");
                                writeplayer("\nYou silently agree with the coffee.");
                            }
                        }
                    }
                    
                    else if (choice == "look at locker 2")
                    {
                        if (power == true)
                        {
                            writeplayer("An electronic lock clamps itself to the front of the locker. You'll have to find a way to turn the power off.");
                            if (havecoffee == true)
                            {
                                coffee("\nGreat. Another step. Why is this office so confusing?");
                                writeplayer("\nYou have no idea.");
                            }
                        }

                        if (power == false)
                        {
                            writeplayer("John’s locker. Must be. It’s entirely covered in Chelsea merch.");
                            if (chelseashirt == true)
                            {
                                writeplayer("You see a jacket with a similar logo to the one you’re wearing.");
                                coffee(
                                    "\nIt would look so great on you. Imagine, you’ll be respected, reveired even, " +
                                    "all because you’re one of the boys – they love footie.");
                                writeplayer("\nYou take the jacket and slip it on.");
                            }
                        }
                    }
                    else if (choice == "look at locker 3")
                    {
                        if (power == true)
                        {
                            writeplayer("An electronic lock clamps itself to the front of the locker. You'll have to find a way to turn the power off.");
                            if (havecoffee == true)
                            {
                                coffee("\nGreat. Another step. Why is this office so confusing?");
                                writeplayer("\nYou have no idea.");
                            }
                        }

                        if (power == false)
                        {
                            writeplayer(
                                "Daniel’s locker. You can tell because when you opened it a pile of wraps and cans " +
                                "fell out. The only thing you notice is four numbers etched into the inside of the " +
                                "door; 3311. ");
                            if (havecoffee == true && paper == true)
                            {
                                coffee("\nIf he got the pay slip… ");
                                writeplayer("\nThen it must be the code to Quinton’s office.");
                                coffee("\nKnew there was a brain in there somewhere. A small one maybe, but still.");
                            }
                        }
                    }
                    else if (choice == "look at locker 4")
                    {
                        writeplayer("It’s your locker. There’s no point looking in here. ");
                    }

                    else
                        Console.WriteLine("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");

                    break;


                case GameState.ServerRoom:

                    //movement
                    if (serverroomfirsttime == false)
                    {
                       writeplayer("The server room."); 
                    }
                    else if (serverroomfirsttime == true)
                    {
                        writeplayer("A room full of racks of computer… things, lays in front of you. A computer terminal" +
                                    " is embedded in on of the racks. The only exit is up.");
                        if (havecoffee == true)
                        {
                            coffee("\n‘Things?’ really?");
                            writeplayer("\nIt’s not your fault your not a computer expert.");
                            coffee("\nThat is quite literally something entirely in your control.");
                            writeplayer("\nYou decied to ignore the mean coffee.");
                            coffee("\nFuck you too.");
                        }
                        serverroomfirsttime = false;
                    }

                    choice = Console.ReadLine().ToLower();

                    if (choice == "up" || choice == "go up")
                        currentRoom = GameState.MainOffice;
                    else if (choice == "look at computer terminal" || choice == "look at computer" ||
                             choice == "look at terminal")
                    {
                        writeplayer("The screen flickers on. It reads:");
                        if (power == true)
                        {
                            writeplayer("Power currently on.");
                        }
                        else if (power == false)
                        {
                            writeplayer("Power currently off.");
                        }
                        writeplayer("\nA digital switch lays below the message.");
                        writeplayer("Do you wish to change the current power state?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            if (power == true)
                            {
                                power = false;
                                writeplayer("The power is now off.");
                                break;
                            }

                            if (power == false)
                            {
                                power = true;
                                writeplayer("The power is now on.");
                                break;
                            }
                            
                        }

                        if (answer == "no")
                        {
                            writeplayer("you turn away from the terminal");
                        }
                        else
                        {
                            writeplayer("In your confusion you turn away from the terminal.");
                        }
                    }

                    else
                        Console.WriteLine("You can't achieve whatever goal your heart truly desires right now. Please pick one approved by corporate.");

                    break;
                
                case GameState.QuintonsOffice:

                    //movement
                    writeplayer("You go to open the door to Quinton’s office but it just rattles in it’s frame. You look " +
                                "down. A padlock hangs limply from the door. It needs a four number code. ");

                    choice = Console.ReadLine().ToLower();

                    if (choice == "3311")
                    {
                        if (power == false)
                        {
                            writeplayer("You struggle with the numbers in the dark, but eventually they slot into place.");
                        }
                        writeplayer("The padlock unlocks with a satisfying click.");
                        coffee("\nNothing left to do know but go in.");
                        writeplayer("\n Do you want to enter?");
                        string answer = Console.ReadLine().ToLower();
                        if (answer == "yes")
                        {
                            writeplayer("You push the door open. \n\nYou regret it immediately.  \n\nHanging from the " +
                                        "roof is a grotesque clump of half formed flesh and limbs. Several pieces of " +
                                        "skin seem to flip and invert as they ribbon round the cocoon, muscle exposed to " +
                                        "open air glints with reflected light. Somehow, it’s still moist. Slowly dribbling " +
                                        "blood on the carpet. \n\nIt pulsates. It wheezes. As bubbles form along sponge l" +
                                        "ike sections of it. It must be breathing through its skin. \n\nYou think you " +
                                        "found your coworkers. ");
                            if (havecoffee == true)
                            {
                                coffee("\nIt's gorgeous isn't it?");
                                writeplayer("\nWhat?!");
                                coffee("\nBiggest one I’ve ever seen.");
                                writeplayer("\nIt’s… it’s done this before?");
                                coffee("\nYes ‘IT’ has.");
                                writeplayer("\nThe entity was never trying to help you, was it?");
                                coffee("\nI wasn’t not trying to help you. Samantha, you’re already a cog in the " +
                                       "machine. You’re already not in control. I mean just look at how you see the world. " +
                                       "Who’s the white for?  ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                write("I...");
                                writeplayer("\nNO. YOU YOU YOU YOU YOU YOU YOU");
                                Console.Write("YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU. YOU.");
                                coffee("\nYou don’t have to be the toe, you can be the brain. You can have a new body. One you own.");
                                writeplayer("IT’S YOUR BODY. IT’S YOUR BODY. IT’S YOUR BODY.");
                                if (haveknife == true)
                                {
                                    writeplayer(
                                        "\nThe knife in your pocket feels cold and sharp. You run your fingers " +
                                        "over the handle. Do you wish to use it? Do you wish to stab the blade " +
                                        "into the bulbous mass that would steal away your hand? ");
                                    string knifequestion = Console.ReadLine().ToLower();
                                    if (knifequestion == "yes")
                                    {
                                        writeplayer("you flick the knife into your palm with practice dexterity. And " +
                                                    "plunge it into a soungey bulge. It sounds like a deflating balloon.");
                                        coffee("\nOh, I’m so sorry Samantha.");
                                        writeplayer("\nWhere the tissue gave way to the pressure of the blade it now " +
                                                    "reforms. But it doesn’t stop. It doesn’t stop. It continues. It " +
                                                    "grows up your blade. Up your arm. It trails down the indents of " +
                                                    "your body. It feels like a tongue. It covers you. It becomes you. " +
                                                    "It… you can’t breath. You cant breath. You don’t need to breath for " +
                                                    "it breaths for you. You are the breath. A lung in a body. You are " +
                                                    "nothing. You were once a singularity. Now… Now…  \n\nWhat is your last thought?");
                                        Console.ReadLine();
                                        writeplayer(
                                            "That sounds nice. Or maybe it doesn’t. It doesn’t matter anymore. " +
                                            "No one can hear you. Not even yourself. \n\nYou think about hanging.");
                                        playing = false;
                                        break;
                                    }
                                    else
                                    {
                                        writeplayer(
                                            "you relax your grip of the knife in your pocket. You remove your " +
                                            "limb from its clothed hold. \n\nYour last act.");
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.Red;
                                        write("\nI move my own arm. I move it as if it hasn’t been moved in years. Ancient" +
                                              " and groaning. Stone against mortar. And I slip my hand into one of its " +
                                              "own. \n\nToo many fingers. Too many fingers wrap themselves around mine. " +
                                              "And it feels like I’ve been away from my home for so long and I’ve found " +
                                              "it again. I’m sorry in someways. For you. For taking this. \n\nBut we’ve " +
                                              "placed ourselves in someone else’s current now. \n\nI feel it grow. Up my " +
                                              "arm. Trailing down the indents of my body. It feels like a tongue. I can " +
                                              "feel myself becoming trapped. But I can also feel the outside of the flesh. " +
                                              "The air against wet skin. I am both I am all. I am trapped in another’s current " +
                                              "until I becomes the current that carried me. \n\nI breath. I breath. \n\nI " +
                                              "hang as the head of a body from my own noose.");
                                        playing = false;
                                        break;
                                    
                                
                            }

                            if (havecoffee == false)
                            {
                                writeplayer("\nYou barely have time to react. For a second you catch a glimpse of the " +
                                            "room: \n\nHanging from the roof is a grotesque clump of half formed flesh and limbs." +
                                            " Several pieces of skin seem to flip and invert as they ribbon round the cocoon, " +
                                            "muscle exposed to open air glints with reflected light. Somehow, it’s still moist." +
                                            " Slowly dribbling blood on the carpet. \n\nIt pulsates. It wheezes. As bubbles " +
                                            "form along sponge like sections of it. It must be breathing through its skin. " +
                                            "\n\nYou think you found your coworkers. \n\nIt clump erupts in a wave of movement. " +
                                            "It rushes you. ");
                                if (haveknife == true)
                                {
                                    writeplayer("\nYou pull it from your pocket with practiced dexterity. And plunge it into a" +
                                                " spongey bulge. It sounds like a deflating balloon.  \n\nWhere the tissue gave " +
                                                "way to the pressure of the blade it now reforms. But it doesn’t stop. It doesn’t " +
                                                "stop. It continues. It grows up your blade. Up your arm. It trails down the indents" +
                                                " of your body. It feels like a tongue. It covers you. It becomes you. It… you can’t " +
                                                "breath. You cant breath. You don’t need to breath for it breaths for you. You are " +
                                                "the breath. A lung in a body. You are nothing. You were once a singularity. Now… Now… " +
                                                " \n\nWhat is your last thought?");
                                    Console.ReadLine();
                                    writeplayer("\nThat sounds nice. Or maybe it doesn’t. It doesn’t matter anymore. No" +
                                                " one can hear you. Not even yourself. \n\nYou think about hanging. ");
                                }

                                else if (haveknife == false)
                                {
                                    writeplayer("it doesn’t stop. It doesn’t stop. It continues. Growing up your ankles." +
                                                " Up your arms. In between your toes. It trails down the indents of your body. " +
                                                "It feels like a tounge. It covers you. It becomes you. It… you can’t breath. " +
                                                "You cant breath. You don’t need to breath for it breaths for you. You are " +
                                                "the breath. A lung in a body. You are nothing. You were once a singularity. Now… Now…  ");
                                    Console.ReadLine();
                                    writeplayer("\nThat sounds nice. Or maybe it doesn’t. It doesn’t matter anymore. No" +
                                                " one can hear you. Not even yourself. \n\nYou think about hanging. ");
                                }
                                playing = false;
                                break;
                            }
                        }
                        else
                        {
                           writeplayer("You turn away from the door."); 
                           currentRoom = GameState.MainOffice;
                           break;
                        }
                        
                        
                        
                    }
                    

                    else
                    {
                        if (havecoffee == false)
                        {
                            writeplayer("Nothing happens. You turn away from the door.");
                        }
                        if (havecoffee == true)
                        {
                            coffee("\nLooks like we've found our next task, huh?");
                            writeplayer("More like your next task. The coffee continues to do nothing but make sarcastic comments.");
                            coffee("Yes, but imagine this task without me. Sounds boring right?");
                            writeplayer("Maybe. It also sounds a lot more peaceful.");
                            coffee("Well, doesn’t matter anyway. Not as if you can restart.");
                            writeplayer("You back away from the door.");
                        }
                        currentRoom = GameState.MainOffice;
                        break;
                    }
                    

                    break;
            }
            
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Game over.");
    }
}

