namespace MainApp.Exercises.Nedarvning;

// computer klassen som nedarver Furniture klassen. (er en computer furniture?)
// computer klassen har 2 ekstra variabel name og cpu
public class Computer : Furniture
{
    public string name { get; set; }
    private string cpu;
    
    public Computer(double price, int quantity, string name, string cpu) : base(price, quantity)
    {
        this.quantity = quantity;
        this.price = price;
        this.name = name;
        this.cpu = cpu;
    }
    
    public string Cpu { get => cpu; set => cpu = value; }
}