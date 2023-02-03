// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are to young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are to young to use Instagram.");
}
