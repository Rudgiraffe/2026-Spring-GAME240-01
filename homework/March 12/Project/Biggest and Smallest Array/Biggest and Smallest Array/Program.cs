int[] numbers = { 9, 50, 23, 99, -11};

int SmallGuy = numbers [0];
int LargeGuy = numbers [0];

int Tim = 1;

while (Tim < SmallGuy)
{
    if (numbers[Tim] > LargeGuy)
        {
        LargeGuy = numbers[Tim];
        }
    if (numbers[Tim] < SmallGuy)
        {
        SmallGuy = numbers[Tim];
        }
    Tim++;
}

Console.WriteLine("The largest number is: " + LargeGuy);
Console.WriteLine("The smallest number is: " + SmallGuy);