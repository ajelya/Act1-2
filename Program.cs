Console.WriteLine("Welcome to Console of Compliments!<3\n");

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("\nHow are you feeling today, " + name + "?");


int choice=0;


while (choice != 1 && choice != 2)
{
    Console.Write("(1)Happy\n(2)Sad\nMOOD= ");
    choice = int.Parse(Console.ReadLine());

    Console.Write("\n");

    if (choice == 1)
    {
        Console.WriteLine("<3 Happiness looks good on you!");
        
        int happychoice=0;
        
        while(happychoice !=1&&happychoice!=2)
        {
             Console.WriteLine("Pick Number for a surpise: (1)(2)");
             happychoice = int.Parse(Console.ReadLine());
            
        if(happychoice==1)
            {
                Console.WriteLine("Choose joy, and let it brighten everything around you");
            }
            else if(happychoice==2)
            {
                Console.WriteLine("A happy heart makes a beautiful soul");
            }else
            {
                 Console.WriteLine("Invalid choice! Please try again:)\n");   
            }
        }
    }
    else if (choice == 2)
    {
        Console.WriteLine("</3 Everything will work out just fine! Keep going!");

        int sadchoice=0;
        while (sadchoice !=1&&sadchoice!=2)
            {
             Console.WriteLine("Pick Number for some happy pill: (1)(2)");
             sadchoice = int.Parse(Console.ReadLine());
            
     if(sadchoice==1)
            {
                Console.WriteLine("Tough times don’t last, but tough people do");
            }
            else if(sadchoice==2)
            {
                Console.WriteLine("You’ve made it through 100% of your bad days so far.");
            }else
            {
                 Console.WriteLine("Invalid choice! Please try again:)\n");   
            }    
        }
    }
    else
    {
        Console.WriteLine("Invalid choice! Please try again:)\n");
    }
}

Console.Write("Have a good day ahead! Just visit me for some motivation!!! <3");
