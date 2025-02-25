using MainApp.UserInterface.userInput;

namespace MainApp.Exercises;

// Dette er klassen til at vise opgaverne fra Public, Private og Protected
public class PublicPrivateProtected
{
    
    // readText() metoden til at printe teksten fra filen pppExplained som er en txt fil der svarer
    // på opgaverne
    // vi har to string variabler en til at gemme fil stien
    // og en til at gemme en linje af gange fra vores txt fil
    // vi bruger et StreamReader object til at læse en linje af gange med ReadLine() metoden indtil der ikke er flere linjer tilbage
    public static void readText()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../resourceses/pppExplained.txt");
        StreamReader sr = new StreamReader(filePath);
        string line = "";

        Console.Clear();
        try
        {
            while ((line = sr.ReadLine()) != null)
            {
                Console.Write("{0}\n", line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Problem reading from file:\n{0}", e.Message);
        }
        
        MainInput.PressToReturn();
    }
}