string role = "Root";

string message = GetWelcomeMessage(role);
Console.WriteLine(message);

string GetWelcomeMessage(string role)
{
    switch (role)
    {
        case "Admin":
            return "Welcome admin! There are 23 players in the server";
        case "Mod":
            return "Welcome, There are 23 players in the server and 3 of them are using hacks";
        case "Player":
            return "Welcome player! Have a good time playing in our server";
        default:
            return "Welcome! But we don't know what your role is";
    }
}