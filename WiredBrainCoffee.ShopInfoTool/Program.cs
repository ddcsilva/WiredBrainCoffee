Console.WriteLine("-----------------------------------");
Console.WriteLine("Wired Brain Coffee - Shop Info Tool");
Console.WriteLine("-----------------------------------");
Console.WriteLine();
Console.WriteLine("Commands:");
Console.WriteLine("quit - Exit Application");

while (true)
{
    var command = Console.ReadLine();

    if (string.Equals("quit", command, StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
}