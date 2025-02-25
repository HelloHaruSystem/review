namespace MainApp.Exercises.Nedarvning;

// bog klassen med 2 instance variabler
public class Bog
{
    private int pris;
    private string titel;

    // Konstrukter 1
    public Bog(int pris, string titel)
    {
        this.pris = pris;
        this.titel = titel;
    }

    // Konstrukter 2
    public Bog(string titel)
    {
        this.pris = 150;
        this.titel = titel;
    }
    
    // PrintInfo metoden
    public void PrintInfo()
    {
        Console.WriteLine("Jeg er en bog.");
    }

    // harRåd metoden
    public bool harRåd(int penge)
    {
        return this.pris <= penge;
    }

    // getters and setters
    public int Pris { get => pris; set => pris = value; }
    public string Titel { get => titel; set => titel = value; }
}
