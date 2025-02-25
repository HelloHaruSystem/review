using System.Text;
using MainApp.UserInterface.userInput;

namespace MainApp.UserInterface;

// mainMenu klassen bruger vi til alt hvad der har med hovede menuen at gøre
public class MainMenu
{
    // 2 instance variabler 
    // en Stringbuilder object så vi kan "loade" menu'en en enkelt gang og printe den til konsollen når vi har brug for det
    // en bool vi bruger til at holde øje med når programmet skal køre eller lukke
    private StringBuilder menuBuilder;
    private bool running;

    // Konstruktor metode til vores MainMenu klasse
    // her instansere vi vores Stringbuilder og running boolean
    // Vi kalder også på loadMenu() metoden for at "loade" vores menu i vores stringbuilder.
    public MainMenu()
    {
        menuBuilder = new StringBuilder();
        this.running = false;
        this.loadMenu();
    }
    
    // start() metode til at starte menuen 
    // den er public så vi kan kalde den ude fra denne klasse
    public void Start()
    {
        // når vi starter sætter vi running til true
        this.running = true;

        // vores hovede loop for programmet
        // vi starter med at clear skærmen og vise menuen
        while (running)
        {
            Console.Clear();
            this.DisplayMainMenu();
            running = MainInput.MainMenuChoice();


            
        }
    }

    // loadmeny() metoden bruger vil til at "Append" menu til vores StringBuilder
    // den er private da vi kun har brug for at kalde metoden fra denne klasse
    private void loadMenu()
    {
        this.menuBuilder.Append("#======================================#\n");
        this.menuBuilder.Append("#            Vælg en opgave            #\n");
        this.menuBuilder.Append("#======================================#\n");
        this.menuBuilder.Append("|[1]                          Variabler|\n");
        this.menuBuilder.Append("|[2]                            Strings|\n");
        this.menuBuilder.Append("|[3]                 Aritmetiske udtryk|\n");
        this.menuBuilder.Append("|[4]                 Variabler i udtryk|\n");
        this.menuBuilder.Append("|[5]                   Boolske variable|\n");
        this.menuBuilder.Append("|[6]                 If-else statements|\n");
        this.menuBuilder.Append("|[7]                        Switch Case|\n");
        this.menuBuilder.Append("|[8]                              Loops|\n");
        this.menuBuilder.Append("|[9]          Udvidet kontrolstrukturer|\n");
        this.menuBuilder.Append("|[10]              Metoder og instanser|\n");
        this.menuBuilder.Append("|[11]           Returtyper og parametre|\n");
        this.menuBuilder.Append("|[12]                 Instancevariabler|\n");
        this.menuBuilder.Append("|[13]                        Nedarvning|\n");
        this.menuBuilder.Append("|[14]                      Konstruktors|\n");
        this.menuBuilder.Append("|[15]                            Arrays|\n");
        this.menuBuilder.Append("|[16]               Gennemløb af arrays|\n");
        this.menuBuilder.Append("|[17]      Public, Private og Protected|\n");
        this.menuBuilder.Append("|[x]                       For at lukke|\n");
        this.menuBuilder.Append("#======================================#\n");
        this.menuBuilder.Append("# Tast tallet ud fra opgaven du vil se #\n");
        this.menuBuilder.Append("#======================================#\n");
    }

    // DisplayMainMenu() Metode til at printe vores menu til konsollen
    // vi sætter også ForegroundColor til grøn
    private void DisplayMainMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(this.menuBuilder.ToString());
    }
}