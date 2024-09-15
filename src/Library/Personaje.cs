using System.Collections;

namespace Library;

public class Personaje
{
    private string nombre;
    private string raza;
    private int vida;
    private int ataque;
    private int defensa;
    private ArrayList lista_items = new ArrayList();

    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }
    
    public string Raza
    {
        get { return this.raza; }
        set { this.raza = value; }
    }

    public int Vida
    {
        get { return this.vida;}
        set { this.vida = value; }
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
        this.vida = 100;
        this.ataque = chequeo_raza.ataque;
        this.defensa = chequeo_raza.defensa;
    }
    
    
    // Método para agregar item tanto de ataque como de defensa
    public void agregar_item(Item item)
    {
        if (lista_items.Contains(item.Nombre))
        {
            Console.WriteLine("Este objeto ya se encuentra equipado");
        }
        else
        {
            lista_items.Add(item.Nombre);
            ataque += item.Ataque;
            defensa += item.Defensa;
        }
    }
    
    // Método para eliminar item tanto de ataque como de defensa
    public void quitar_item(Item item)
    {
        if (lista_items.Contains(item.Nombre))
        {
            lista_items.Remove(item.Nombre);
            ataque -= item.Ataque;
            defensa -= item.Defensa;
        }
        else
        {
            Console.WriteLine("Este objeto no se encuentra equipado");
        }
    }
    
    // Método para saber el valor de ataque que tiene el personaje
    public void ValorAtaque()
    {
        Console.WriteLine("El valor de ataque total es: " + ataque);
    }
    
    // Método para saber el valor de defensa que tiene el personaje
    public void ValorDefensa()
    {
        Console.WriteLine("El valor de defensa total es: " + defensa);
    }
}