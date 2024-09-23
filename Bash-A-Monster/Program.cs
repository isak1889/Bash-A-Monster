using Bash_A_Monster;

Megaman theMegaman = new Megaman();

Monster theMonster = new Monster();

Console.WriteLine($"{theMegaman.name} har {theMegaman.health} hp");
Console.WriteLine($"{theMonster.name} har {theMonster.health} hp och {theMonster.size} storlek") ;

Console.WriteLine("ATTACKERA!");


theMonster.health -= 10;

Console.WriteLine($"{theMonster.name} har nu {theMonster.health} hp");

Console.ReadLine();