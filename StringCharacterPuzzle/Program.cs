string stuff = Console.ReadLine();

char[] chars = stuff.ToCharArray();

Console.WriteLine("");
Console.WriteLine(stuff);
Console.WriteLine("");
Console.WriteLine($"Your string is {stuff.Length} characters long.");
Console.WriteLine("");

if(stuff.Length % 2 == 0)
{
    Console.WriteLine("Your string has an even number of characters.");
    Console.WriteLine($"The middle 2 characters are '{chars[stuff.Length / 2 -1]}', '{chars[stuff.Length / 2]}'.");
} else
{
    Console.WriteLine("Your string has an odd number of characters.");
    Console.WriteLine($"The middle character is '{chars[stuff.Length / 2]}'.");
}