// See https://aka.ms/new-console-template for more information
using RoshamboRockPaperScissors;

Console.WriteLine("Hello, World!");

HumanPlayer humanPlayer = new("Human");
RandomPlayer randomPlayer = new RandomPlayer("Harry");
RockPlayer rockPlayer = new("Rocky");

Console.WriteLine($"RockPlayer(p1): {rockPlayer.Name}");
Console.WriteLine($"RandomPlayer(p2): {randomPlayer.Name}");
Console.WriteLine($"HumanPlayer: {humanPlayer.Name}");

Roshambo humanPlayerValue = humanPlayer.GenerateRoshambo();
//Console.WriteLine($"Human Player Choice: {humanPlayerValue}");
Roshambo randomPlayerValue = randomPlayer.GenerateRoshambo();
//Console.WriteLine($"Random Player Choice: {randomPlayerValue}");
Roshambo rockPlayerValue = rockPlayer.GenerateRoshambo();
//Console.WriteLine($"Random Player Choice: {rockPlayerValue}");

//Console.Write($"Select a player: randomPlayer(p1), rockPlayer(p2):  ");
Console.Write($"Select a player: Harry(p1), Rocky(p2):  ");
string userChoice = Console.ReadLine();
Console.WriteLine(userChoice);

if (userChoice.ToLower() == "p1")
{
    //Console.WriteLine(userChoice.ToLower());
    if (humanPlayerValue == randomPlayerValue)
    {
        Console.WriteLine($"Match Draw");
    }
    else if (humanPlayerValue == Roshambo.rock)
    {
        if (randomPlayerValue == Roshambo.paper)
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is {randomPlayer.Name}:  Wins!");
        }
        else
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is {humanPlayer.Name}:  Wins!");
        }
    }
    else if (humanPlayerValue == Roshambo.paper)
    {
        if (randomPlayerValue == Roshambo.rock)
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is {humanPlayer.Name}:  Wins!");
        }
        else
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is {randomPlayer.Name}:  Wins!");
        }
    }
    else
    {
        if (randomPlayerValue == Roshambo.rock)
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is  {randomPlayer.Name}:  Wins!");
        }
        else
        {
            Console.WriteLine($"Players: {randomPlayer.Name} {randomPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
            Console.WriteLine($"Result is  {humanPlayer.Name}:  Wins!");
        }
    }
}
else
{
    if (humanPlayerValue == rockPlayerValue)
    {
        Console.WriteLine($"Match Draw");
    }
    else if (humanPlayerValue == Roshambo.paper)
    {
        Console.WriteLine($"Player: {rockPlayer.Name} {rockPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
        Console.WriteLine($"Result is {humanPlayer.Name}:  Wins!");
    }
    else if (humanPlayerValue == Roshambo.scissors)
    {
        Console.WriteLine($"Player: {rockPlayer.Name} {rockPlayerValue} and {humanPlayer.Name} {humanPlayerValue} ");
        Console.WriteLine($"Result is {rockPlayer.Name}:  Wins!");
    }
}