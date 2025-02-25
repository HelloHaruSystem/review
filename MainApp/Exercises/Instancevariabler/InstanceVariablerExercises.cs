using MainApp.UserInterface.userInput;

namespace MainApp.Exercises.Nedarvning;

public class InstanceVariablerExercises
{
    // opgave 1 i Instancevariabler ved at bruge bog klassen fra den tidligere opgave og givet den instance variabler
    // og retter Harråd metoden til så den kun har en parameter.
    // kan jeg nu teste programmet med 2 Console.WriteLine metoder hvor jeg bruger getters
    public static void Opg1()
    {
        Bog sherlockHolmes = new Bog("Sherlock Holmes");
        Bog mobyDick = new Bog(250,"Moby Dick");
        
        Console.Clear();
        Console.WriteLine("\nOpgave 1 (Brug klassen Bog fra forrige opgave):\n" +
                          "1. Lav 2 instansvariabler i din Bog klasse: en int: pris og en string: titel.\n" +
                          "2. Lav set og get metoder til begge instansvariabler.\n" +
                          "3. Ændrer din metode: HarRåd så den kun tager 1 parameter (de penge vi har at købe for). Den\n" +
                          "skal nu sammenligne med den pris der står som instansvariable.\n" +
                          "4. Test dit program: Kald alle metoder, og udskriv formen: \"(title) - koster (pris) kr.\" For\n" +
                          "eksempel: \"Moby Dick - koster 240 kr.\"\n\n");

        Console.WriteLine("Her kalder jeg metoderne!");
        Console.WriteLine("\n{0} - Koster {1} Kr.", mobyDick.Titel, mobyDick.Pris);
        Console.WriteLine("{0} - Koster {1} Kr.", sherlockHolmes.Titel, sherlockHolmes.Pris);
        
        MainInput.PressToReturn();
    }
}