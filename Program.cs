// See https://aka.ms/new-console-template for more information
string temp;
string ageAsString;
int age;
Console.WriteLine("write down you name: ");
temp= Console.ReadLine();
Console.WriteLine($"congrats your a member now {temp}");
Console.WriteLine("Please enter your age: ");
ageAsString = Console.ReadLine();
age = Convert.ToInt32(ageAsString);
Console.WriteLine($"{temp} you are {age} year old");

Console.Writeline("this is just to test for merge conflicts and how to solve it");
Console.WriteLine("we cant figure it out");
