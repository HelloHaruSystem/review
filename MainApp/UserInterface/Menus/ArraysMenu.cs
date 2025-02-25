using System.Text;
using MainApp.UserInterface.userInput;

namespace MainApp.UserInterface;

// klassen vi bruger til at printe gennemløb af array menuen til konsollen
// vi bruger samme metode med en stringbuilder som vi gjorde med hovedmenuen
public class ArraysMenu
{
    public static void Arraysmenu()
    {
        bool stayInMenu = true;
        StringBuilder menuBuilder = new StringBuilder();
        
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("#         Vælg en opgave fra           #\n");
        menuBuilder.Append("#               arrays                 #\n");
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("|[1]                           Opgave 1|\n");
        menuBuilder.Append("|[2]                           Opgave 2|\n");
        menuBuilder.Append("|[3]                           Opgave 3|\n");
        menuBuilder.Append("|[x]        Går tilbage til hovedmenuen|\n");
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("# Tast tallet ud fra opgaven du vil se #\n");
        menuBuilder.Append("#======================================#\n");

        while (stayInMenu)
        {
            Console.Clear();
            Console.Write(menuBuilder.ToString());
            stayInMenu = ArrayInput.ArraysMenuChoice();
        }
        
    }
}