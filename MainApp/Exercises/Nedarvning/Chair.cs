namespace MainApp.Exercises.Nedarvning;

// chair klassen som nedarver Furniture klassen.
// Chair klassen har en ekstra variabel type
public class Chair : Furniture
{
    private string type;
    
    public Chair(double price, int quantity, string type) : base(price, quantity)
    {
        this.price = price;
        this.quantity = quantity;
        this.type = type;
    }

    public string Type
    {
        get { return this.type; }
    }
    
}