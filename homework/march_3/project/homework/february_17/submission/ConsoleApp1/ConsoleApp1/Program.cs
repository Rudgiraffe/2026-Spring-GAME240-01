Console.WriteLine("Hello, what is your name?");

var name = Console.ReadLine();

Console.Write("Hello there, ");

Console.WriteLine(name);

Console.WriteLine("how old are you?");

var age = Console.ReadLine();

Console.WriteLine("Is it your Bday?");

var bday = Console.ReadLine();

if (bday == "yes") 
{Console.WriteLine("HAPPY BDAY");}
else if (bday == "no") {Console.WriteLine("oh, ok.");}

else
{
    Console.WriteLine("It's a yes or no question. Why would you even type that?");
}

Console.Write("So,");
Console.Write(name);
Console.Write(", ");
Console.WriteLine(age);
Console.Write(", ");
if (bday == "yes") {Console.Write("Birthday human,");}
if (bday == "no") {Console.WriteLine("Non-Birthday human,");}

Console.WriteLine("How are you doing today?");

Console.ReadLine();

Console.WriteLine("Actually... well, I'm a computer code, so that's way too broad a question for me to directly answer.");
Console.WriteLine("Let's try this;");
Console.WriteLine("How are you doing today?");
Console.WriteLine("A.Good " +
                  "B.Bad " +
                  "C.Meh, I mean it could be better but it could be worse, the world's kinda falling apart but I'm mostly fine so...");
var mood = Console.ReadLine();
if (mood == "A")
{Console.WriteLine("I'm glad to hear it. (ooo upper case, fancy).");}

else if (mood == "a")
{Console.WriteLine("I'm glad to hear it. (what? couldn't be bothered to do upper case).");}

else if (mood == "B")
{Console.WriteLine("Get it together. (ooo upper case, fancy).");}

else if (mood == "b")
{Console.WriteLine("Get it together. (what? couldn't be bothered to do upper case?)");}

else if (mood == "c")
{Console.WriteLine("Honestly at this point, just stop reading the news. Turn your brain off. Enjoy life. Capitalise your letters.");}
else if (mood == "C")
{Console.WriteLine("Honestly at this point, just stop reading the news. Turn your brain off. Enjoy life.");}
