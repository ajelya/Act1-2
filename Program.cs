// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Console of Compliments!<3\n");

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("\nHow are you feeling today, " + name + "?");

Console.Write("(1)Happy\n(2)Sad\nMOOD= ");
int choice = int.Parse(Console.ReadLine());

Console.WriteLine();

if (choice == 1)
{
    Console.WriteLine("<3 Happiness looks good on you!");
}
else if (choice == 2)
{
    Console.WriteLine("</3 Everything will work out just fine! Keep going!");
}
else
{
    Console.WriteLine("Invalid choice! Please try again:)");
}

Console.Write("Have a good day ahead! Just visit me for some motivation!!! <3");
