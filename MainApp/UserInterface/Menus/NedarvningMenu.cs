using System.Text;
using MainApp.UserInterface.userInput;

namespace MainApp.UserInterface;

public class NedarvningMenu
{
    public static void Nedarvningsmenu()
    {
        bool stayInMenu = true;
        StringBuilder menuBuilder = new StringBuilder();
        
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("#         Vælg en opgave fra           #\n");
        menuBuilder.Append("#             Nedarvning               #\n");
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
            stayInMenu = NedarvningInput.NedarvningMenuChoice();
        }
        
    }
}