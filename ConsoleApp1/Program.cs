

Console.WriteLine("Zadej výšku pyramidy");
string inputFromUser = Console.ReadLine();
int height=0;

if (!Int32.TryParse(inputFromUser, out height))
{
    Console.WriteLine("Neplatný vstup zadej číslo");
    Environment.Exit(0);
}

decimal stars = 1;
for (int i = 1; i < height; i++)
{
    stars += 2;
}
decimal startPoint=Math.Floor(stars/2);
string star = "*";


for (int i = 0; i < height-1; i++)
{
    string emptySpace = "";
    for (int j = 0; j < startPoint; j++)
    {
        emptySpace += " ";
    }

    if (i==0)
    {
        Console.Write(emptySpace);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(star);
    }
    else
    {
        Console.WriteLine();
        Console.Write(emptySpace);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(star);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
    
        star += "**";
    }
    
    startPoint -= 1;
}

star += "**";
Console.WriteLine();
Console.WriteLine(star);

string emptySpaceRevers = " ";

star = star.Substring(2);

for (int i = height-1; i > 1; i--)
{
    star = star.Substring(2);
    Console.Write(emptySpaceRevers);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("*");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(star);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("*");
    
    emptySpaceRevers += " ";
    Console.WriteLine();
}

Console.Write(emptySpaceRevers);
Console.ForegroundColor = ConsoleColor.Red;

Console.Write("*");
Console.ReadKey();