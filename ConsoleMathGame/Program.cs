using ConsoleMathGame;

var menu = new Menu();

string name = GetName();
var date = DateTime.UtcNow;

var games = new List<string>();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}