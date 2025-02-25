using MainApp.UserInterface.userInput;

namespace MainApp.Exercises.Nedarvning;

public class NedarvningExercises
{
    // opgave 1 er blevet løst med at lave 3 klasser en parent klasse og 2 child klasser
    // Jeg har instantiatet et computer object og et chair object
    // derefter har jeg printet 2 strings der bruger alle instants variabler fra dem
    public static void Opg1()
    {
        Chair officeChair = new Chair(150.95, 100, "Office Chair");
        Computer razerBlade14 = new Computer(8000, 25, "Razer Blade 14", "AMD Ryzen");
        
        Console.Clear();

        Console.WriteLine("Her er to Console.WriteLine() commands hvor jeg har brugt alle instans variabler");
        Console.WriteLine("In storage we have {0} {1} from the maker {2} of a price for a chair is {3} Kr.", officeChair.Quantity, officeChair.Type, officeChair.Maker, officeChair.Price);
        Console.WriteLine($"\nIn storage we have {razerBlade14.Quantity} {razerBlade14.name} from the marker {razerBlade14.Maker} with a {razerBlade14.Cpu} For {razerBlade14.Price} Kr. each");
        
        MainInput.PressToReturn();
    }
}