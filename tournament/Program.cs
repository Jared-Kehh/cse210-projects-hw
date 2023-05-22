// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Player Kobe = new Player("Kobe Bryant", 24, "Shooting Guard");

// Kobe._name = "Kobe Bryant";
// Kobe._position = "Point Guard";
// Kobe._jerseyNumber = 24;


Player neymar = new Player("Neymar jr.", 10);
neymar.SetPosition("Forward");
Team awesomeSauce = new Team("Awesome Sauce");
awesomeSauce.AddPlayer(Kobe);
awesomeSauce.AddPlayer(neymar);
Console.WriteLine(neymar.Display());
awesomeSauce.AddLoss();
awesomeSauce.AddWin();
awesomeSauce.DisplayRoster();