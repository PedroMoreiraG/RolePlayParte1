using System.Collections;

namespace Library;

public class Personaje
{
    private string nombre;
    private string raza;
    private int vida = 100;
    private int ataque;
    private int defensa;

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
    
    
    public Personaje(string nombre, string raza)
    {
        this.nombre = nombre;
        this.raza = raza;
        ChequeoRazas chequeoRazas = new ChequeoRazas();
        chequeoRazas.Estadisticas(this);

    }
    
    
    // Método para saber el valor de ataque que tiene el personaje
    public void ValorAtaque()
    {
        Console.WriteLine($"El valor de ataque total es: {ataque}");
    }
    
    // Método para saber el valor de defensa que tiene el personaje
    public void ValorDefensa()
    {
        Console.WriteLine($"El valor de defensa total es: {defensa}");
    }
}