namespace Library.Personajes;

public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int VidaInicial { get; set; }
    public List<Item> Items { get; set; }

    public Personaje(string nombre, int vidaInicial)
    {
        this.Nombre = nombre;
        this.Vida = vidaInicial;
        this.VidaInicial = vidaInicial;
        this.Items = new List<Item>()

    }
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
    
    // Metodo de ataque a otro personaje

    public void Atacar(Personaje objetivo)
    {
        int daño = this.ObtenerValorAtaque(); // El daño de ataque es el valor de ataque del personaje que ataca
        objetivo.Defensa(daño); // Le pasa el valor de dano a la defensa del objetivo para ver cuanto le saca de vida
    }
    public void Defensa(int daño)
    {
        int defensa = this.ObtenerValorDefensa(); // El daño de ataque es el valor de ataque del personaje que ataca
        int dañoFinal = daño - defensa; // Resta el daño a la defensa del atacado y asigna el nuevo dano
        
        //Evaluamos si la defensa fue mayor a da;o de ser asi, no resta nada a la vida
        
        if (dañoFinal < 0)
        {
            dañoFinal = 0;
        }

        objetivo.Vida -= dañoFinal; // Asignar nueva vida restandole el da;o final
        
        if (objetivo.Vida <= 0)
        {
            objetivo.Vida = 0;
        }
    }
//Metodo para reiniciar la vida a su vida inicial
    public void Curar()
    {
        this.Vida = this.VidaInicial;
    }
    
    
}