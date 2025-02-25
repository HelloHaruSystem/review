﻿using System.Text;
using MainApp.UserInterface.userInput;

namespace MainApp.UserInterface;

// klassen vi bruger til at printe gennemløb af array menuen til konsollen
// vi bruger samme metode med en stringbuilder som vi gjorde med hovedmenuen
public class KonstruktorsMenu
{
    public static void Konstruktormenu()
    {
        bool stayInMenu = true;
        StringBuilder menuBuilder = new StringBuilder();
        
        menuBuilder.Append("#======================================#\n");
        menuBuilder.Append("#         Vælg en opgave fra           #\n");
        menuBuilder.Append("#            Konstruktors              #\n");
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
            stayInMenu = KonstruktorsInput.KonstruktorsMenuChoice();
        }
        
    }
}