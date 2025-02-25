namespace MainApp.Exercises.Nedarvning;

// Furniture klassen er en abstract klasse så man kan ikke instansiete den!
// dens make variable er private da de 2 andre klasser nedarver dens værdi så de har ikke brug for at sætte værdien i deres
// Konstruktor.
// de andre to er protected så all dens child klasses har adgang til dem.
public abstract class Furniture
{
    private string maker;
    protected double price;
    protected int quantity; 

    protected Furniture(double price, int quantity)
    {
        this.maker = "Razor";
        this.price = price;
        this.quantity = quantity;
    }
    
    // getters and setters
    public string Maker { get => maker; set => maker = value; }
    public double Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }
}