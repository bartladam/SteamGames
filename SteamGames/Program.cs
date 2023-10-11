using SteamGames;

Console.Title = "Steam games";
Steam steam = new Steam(
    new Games("Call of Duty", 350, Games.Genre.Battle),
    new Games("Train simulator", 500, Games.Genre.Simulator),
    new Games("Dungeons", 750, Games.Genre.Fantasy));

User u = new User("Paja", "123", steam);
u.LogIn();


