myLoop:
int number;
Console.WriteLine("Choose your multiplication table.");
bool input = int.TryParse(Console.ReadLine(), out number);

if (input)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(number + "x" + i + "=" + number * i);
    }
    goto myLoop;
}