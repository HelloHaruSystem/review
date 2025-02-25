using MainApp.UserInterface;

namespace MainApp;

class Driver
{
    // Main metoden det er her programmet starter
    // Vi instansierer et mainMenu-objekt og kalder start-metoden for at starte programmet.
    // Console.ReadKey() metoden bruger Vi så konsollen ikke lukker med det samme når programmet slutter.
    static void Main(string[] args)
    { 
        MainMenu mainMenu = new MainMenu();
        
        mainMenu.Start();
    }
}