using System.Text;
using MainApp.UserInterface.userInput;

namespace MainApp.UserInterface;

public class InstancevariablerMenu
{
    public static void InstanceVariablerMenu()
    {
        bool stayInMenu = true;
        StringBuilder menuBuilder = new StringBuilder();
        
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("#         Vælg en opgave fra           #\n");
        menuBuilder.Append("#          Instancevariabler           #\n");
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("|[1]                           Opgave 1|\n");
        menuBuilder.Append("|[x]        Går tilbage til hovedmenuen|\n");
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("# Tast tallet ud fra opgaven du vil se #\n");
        menuBuilder.Append("#======================================#\n");

        while (stayInMenu)
        {
            Console.Clear();
            Console.Write(menuBuilder.ToString());
            stayInMenu = InstanceVariablerInput.InstancevariablerMenuChoice();
        }
        
    }
}