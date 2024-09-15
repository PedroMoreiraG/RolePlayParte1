namespace Library;

public class Item //creamos clase item con sus atributos 
{
    private string nombre;
    private int ataque;
    private int defensa;

    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    
    public int Ataque
    {
        get { return this.ataque; }
        set { this.ataque = value; }
    }

    public int Defensa
    {
        get { return this.defensa; }
        set { this.defensa = value; }
    }

    public Item(string nombre, int ataque, int defensa) //constructor para inicializar el item
    {
        this.nombre = nombre;
        this.ataque = ataque;
        this.defensa = defensa;
    }
}