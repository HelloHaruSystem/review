using MainApp.Exercises;

namespace MainApp.UserInterface.userInput;

public class MainInput
{
    // MainMenuChoice bruger vil til at få bruger input til hovedmenuen
    public static bool MainMenuChoice()
    {
        // vi har to variabler en boolean til at holde styr på om brugeren har givet korrekt input
        // en string til at holde bruger inputet
        bool validInput = false;
        string userInput = "";
        
        // while loop køre til brugeren har givet korrekt input
        while (!validInput)
        {
            Console.Write("> ");
            userInput = Console.ReadLine();
         
            
            // en lang switch statement som sætter validInput variablen til true hvis korrekt input er givet
            // hvis ikke vil brugeren for at vide at inputed var forkert
            // vi kalder så metoden som brugeren har valgt!
            // til sidst rattunere true for valid
            // eller hvis x false
            switch (userInput)
            {
                case "1":
                    validInput = true;
                    break;
                case "2":
                    validInput = true;
                    break;
                case "3":
                    validInput = true;
                    break;
                case "4":
                    validInput = true;
                    break;
                case "5":
                    validInput = true;
                    break;
                case "6":
                    validInput = true;
                    break;
                case "7":
                    validInput = true;
                    break;
                case "8":
                    validInput = true;
                    break;
                case "9":
                    validInput = true;
                    break;
                case "10":
                    validInput = true;
                    break;
                case "11":
                    validInput = true;
                    break;
                case "12":
                    validInput = true;
                    InstancevariablerMenu.InstanceVariablerMenu();
                    break;
                case "13":
                    validInput = true;
                    NedarvningMenu.Nedarvningsmenu();
                    break;
                case "14":
                    validInput = true;
                    KonstruktorsMenu.Konstruktormenu();
                    break;
                case "15":
                    validInput = true;
                    ArraysMenu.Arraysmenu();
                    break;
                case "16":
                    validInput = true;
                    GennemløbAfArraysMenu.GennemløbsMenu();
                    break;
                case "17":
                    validInput = true;
                    PublicPrivateProtected.readText();
                    break;
                case "x":
                    return false;
                default:
                    Console.Write("Forket input prøv igen!");
                    break;
            }
        }
        
        return validInput;
    }

    // en metode vi kalder før brugerenen kommer tilbage til en menu
    public static void PressToReturn()
    {
        Console.Write("\n\nTryk en vilkårlig tast for at vende tilbage til menuen\n> ");
        Console.ReadKey();
    }
}