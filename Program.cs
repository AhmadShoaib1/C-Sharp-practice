// See https://aka.ms/new-console-template for more information

Console.Write("write down you name: ");
string Name = Console.ReadLine();
Console.WriteLine($"congrats your a member now {Name}");
Console.Write("What year were you born in?  ");
int Year = Console.Read();
Console.WriteLine($"Your name is {Name} and your age is {2023 - Year}");
