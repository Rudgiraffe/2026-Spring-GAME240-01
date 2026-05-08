//ok, so this isn't actually running properly, but I can't figure out what's wrong with it.

string specialfishies;
string filetime;
string voila;

string fishieguys = "";
string[] fishieshooked = { };

while (true)
{
    Console.WriteLine("Enter file name for today's special:");
    specialfishies = Console.ReadLine();

    try
    {
        fishieguys = File.ReadAllText(specialfishies).Trim();
        break;
    }
    catch
    {
        Console.WriteLine("Invalid file name. Please try again.");
    }
}

while (true)
{
    Console.WriteLine("Enter file name for fishmonger's log:");
    filetime = Console.ReadLine();

    try
    {
        fishieshooked = File.ReadAllLines(filetime);
        break;
    }
    catch
    {
        Console.WriteLine("Invalid file name. Please try again.");
    }
}

Console.WriteLine("Where would you like to save the results?");
voila = Console.ReadLine();

int specialfishiecount = 0;
int totalfishiecount = 0;
int A = 0;

while (A < fishieshooked.Length)
{
    string currentfishies = fishieshooked[A].Trim();

    if (currentfishies != "")
    {
        totalfishiecount++;

        if (currentfishies.ToLower() == fishieguys.ToLower())
        {
            specialfishiecount++;
        }
    }

    A++;
}

string thefinalfishening =
    "Today's special is " + fishieguys + "\n" +
    "Total " + fishieguys + " caught: " + specialfishiecount + "\n" +
    "Total fish caught: " + totalfishiecount;

File.WriteAllText(voila, thefinalfishening);

Console.WriteLine("Information saved.");
