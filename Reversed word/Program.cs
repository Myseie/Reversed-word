Console.Write("Skriv en mening här :");

string input = Console.ReadLine();

string[] words = input.Split();

Array.Reverse(words);

Console.WriteLine("Omvänd mening : ");
Console.WriteLine(string.Join(" ", words));