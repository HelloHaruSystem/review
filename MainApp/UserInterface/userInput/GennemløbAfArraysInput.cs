﻿using MainApp.Exercises.GennemLøbAfArrays;

namespace MainApp.UserInterface.userInput;

public class GennemløbAfArraysInput
{
    // GennemløbsMenuChoice() til at få bruger input ligesom vi gjorde i hovedmenuen
    public static bool GennemløbsMenuChoice()
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
                    GennemLøbsExercises.Opg1();
                    break;
                case "2":
                    validInput = true;
                    GennemLøbsExercises.Opg2();
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
}