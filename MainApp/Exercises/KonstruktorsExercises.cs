using MainApp.UserInterface.userInput;

namespace MainApp.Exercises;

public class KonstruktorsExercises
{
    public static void Opg1()
    {
        Console.Clear();
        Console.WriteLine("\nOpgave 1:\n" +
                          "1. Lav en konstruktor i din \"Bog\" klasse, der sætter alle instans variablerne.\n" +
                          "2. Lav en konstruktor der kun sætter 1 af dem (du bestemmer hvilken).\n" +
                          "3. Test programmet med begge konstruktorer.\n\n");

        Console.WriteLine("Jeg har løst opgaven på denne måde:\n");

        Console.WriteLine("public class Bog\n" +
                          "{\n" +
                          "    private int pris;\n" +
                          "    private string titel;\n" +
                          "\n    public Bog(int pris, string titel)\n" +
                          "    {\n" +
                          "        this.pris = pris;\n" +
                          "        this.titel = titel;\n" +
                          "    }\n" +
                          "\n" +
                          "    public Bog(string titel)\n" +
                          "    {\n" +
                          "        this.pris = 150;\n" +
                          "        this.titel = titel;\n    }");
        
        MainInput.PressToReturn();
    }
}