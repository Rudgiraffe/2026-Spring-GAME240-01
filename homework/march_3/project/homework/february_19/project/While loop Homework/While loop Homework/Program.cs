// See https://aka.ms/new-console-template for more information

// 1
int number = 1;
while (number <= 5)
{
    Console.WriteLine(number + " ");
    number++;
}

// 2
int count = 100;
while (count <= 150)
{
    Console.WriteLine(count + " ");
    count++;
}

// 3
// ran out of things to name variables so they're now just expedition 33 characters.
int sciel = 0;
while (sciel <= 100)
{
    Console.Write(sciel + " ");
    sciel += 2;
}

// 4
int maelle = 20;
while (maelle >= -20)
{
    Console.Write(maelle + " ");
}

// 5
int Gustave = 1;
while (Gustave <= 100)
{
    Console.Write(Gustave + " ");
    Gustave += 3;
}

// 6
int lune = 1;
while (lune <= 1024)
{
    Console.Write(lune + " ");
    lune *= 2;
}

// 7
string Verso;
do
{
    Console.WriteLine("Stop the loop?");
    Verso = Console.ReadLine();
}
while (Verso != "yes");

// 8
//naming these random things is now confusing me but I refuse to backtrack
bool Noco = true;
int Monoco = 0;

while (Monoco < 10)
{
    Console.Write(Monoco + " ");
    Noco = !Noco;
    Monoco++;
}

// 9
// I know you said we didn't need division but I honestly found this easier.
int esquie = 1;
while (esquie <= 20)
{
    if (esquie % 2 == 0)
        {
        Console.Write(esquie + "is even");
        }
    else
        {
        Console.Write(esquie + "is odd");
        }
    esquie++;
}

// 10
string[] gestrals = { "once", "upon", "a", "midnight", "dreary"};
int golgra = 0;
while (golgra < gestrals.Length)
{
    Console.Write(gestrals[golgra]);
    golgra++;
}