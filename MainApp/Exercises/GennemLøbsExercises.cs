using MainApp.UserInterface;
using MainApp.UserInterface.userInput;

namespace MainApp.Exercises.GennemLøbAfArrays;

// denne klasse inholder gennemløb af array opgaverne som statiske metoder
public class GennemLøbsExercises
{
    // opgave 1 her bruger vi random til at fylde vores int[] med tilfældige tal med hjælp fra et  for loop
    // derefter regner vi summen med et for loop
    public static void Opg1()
    {
        Random random = new Random();
        int[] array1 = new int[6];
        int sum = 0;

        Console.Clear();
        Console.WriteLine("1. Lav et array med 6 valgfrie værdier og udskriv summen af dem ved at bruge en for-løkke.\n");
        
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = random.Next(1, 101);
        }

        Console.Write("1. summen af array1: ");
        foreach (int i in array1)
        {
            sum += i;
        }

        Console.Write(sum);
        
        MainInput.PressToReturn();
    }

    // opgave 2 vi laver et string[] og printer det til konsollen med hjælp fra et foreach loop
    public static void Opg2()
    {
        string[] array2 = { "What day", "is", "it", "today", "?" };

        Console.Clear();
        Console.WriteLine("2. Lav et string array og sæt 5 strings i.");
        Console.WriteLine("3. Udskriv dem alle via en løkke.\n");

        Console.Write("String array = ");
        foreach (string s in array2)
        {
            Console.Write(s + " ");
        }
        
        MainInput.PressToReturn();
    }
}