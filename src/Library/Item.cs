using System.Collections;

namespace Library;

public class Item //creamos clase item con sus atributos 
{
    private string nombre;
    private int ataque;
    private int defensa;
    private ArrayList lista_items = new ArrayList();

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
    
    // Método para agregar item tanto de ataque como de defensa
    public void agregar_item(Personaje pj)
    {
        if (lista_items.Contains(nombre))
        {
            Console.WriteLine("Este objeto ya estaba equipado");
        }
        else
        {
            lista_items.Add(Nombre);
            pj.Ataque += ataque;
            pj.Defensa += defensa;
        }
    }
    
    // Método para agregar item tanto de ataque como de defensa
    public void quitar_item(Personaje pj)
    {
        if (lista_items.Contains(nombre))
        {
            lista_items.Add(Nombre);
            pj.Ataque += ataque;
            pj.Defensa += defensa;
        }
        else
        {
            Console.WriteLine("Este objeto no se puede quitar porque no se encuentra equipado");
        
        }
    }
}