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
        this.Items = new List<Item>();

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
}