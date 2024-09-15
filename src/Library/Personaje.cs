namespace Library;

public class Personaje
{
    private string nombre;
    private int vida;
    private int vida_inicial;
    private int ataque;
    private int defensa;
    public List<Item> Items { get; set; }

    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public int Vida
    {
        get { return this.vida;}
        set { this.vida = value; }
    }

    public int Vida_Inicial
    {
        get { return this.vida_inicial; }
        set { this.vida_inicial = value; }
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
    
    
    public Personaje(string nombre, int vida, int vida_inicial, ChequeoRaza chequeo_raza)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.vida_inicial = vida_inicial;
        this.ataque = chequeo_raza.ataque;
        this.defensa = chequeo_raza.defensa;
        this.Items = new List<Item>();
    }
    
    
    // Método para agregar item tanto de ataque como de defensa
    // Método para agregar item tanto de ataque como de defensa
    public void AddItem(Item item)
    {
        Items.Add(item);
    }
    
    // Método para eliminar item tanto de ataque como de defensa
    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }
    
    // Método para saber el valor de ataque que tiene el personaje
    public int ValorAtaque()
    {
        return Item.ObtenerValorAtaque(Items); // Implementado en Clase Items
    }
    
    // Método para saber el valor de defensa que tiene el personaje
    public int ValorDefensa()
    {
        return Item.ObtenerValorDefensa(Items); // Implementado en Clase Items
    }
}