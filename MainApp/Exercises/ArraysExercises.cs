using MainApp.UserInterface;
using MainApp.UserInterface.userInput;

namespace MainApp.Exercises;

// opgaverne fra Arrays
public class ArraysExercises
{
    // opgave 1 vi laver 2 int arrays og instantiate'er dem på to forskellige måder 
    public static void Opg1()
    {
        int[] array1 = { -2, -1, 0, 10 };
        int[] array2 = new int[4] { -2, -1, 0, 10 };

        Console.Clear();
        Console.WriteLine("\n1. Lav et array med følgende værdier: -2, -1, 0, 10. Prøv både med {} og med new int[x].\n\n");
        
        Console.WriteLine("Jeg har lavet 2 int arrays:");
        Console.WriteLine("Første Array: int[] array1 = { -2, -1, 0, 10 };");
        Console.WriteLine("Andet Array: int[] array2 = new int[4] { -2, -1, 0, 10 };");
        
        MainInput.PressToReturn();
    }

    // opgave 2 her bruger vi bruger vi det index som værdien ligger på for at printe det ti konsollen. 
    public static void Opg2()
    {
        int[] array1 = { -2, -1, 0, 10 };

        Console.Clear();
        Console.WriteLine("\n2. Udskriv elementet 10 og -1.\n\n");

        Console.WriteLine("Index 3 = " + array1[3]);
        Console.WriteLine("Index 1 = " + array1[1]);
        
        MainInput.PressToReturn();
    }
    
    // opgave 3 for at regne summen af vores array ud bruger jeg metoden Sum på array1 
    public static void Opg3()
    {
        int[] array1 = { -2, -1, 0, 10 };

        Console.Clear();
        Console.WriteLine("\n3. Udskriv summen af alle elementerne i dit array.\n\n");

        Console.WriteLine("Summen af alle elementerne er: " + array1.Sum());
        
        MainInput.PressToReturn();
    }
}