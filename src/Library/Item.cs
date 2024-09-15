namespace Library;

public class Item //creamos clase item con sus atributos 
{
    public string NombreItem { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    public Item(string nombre, int ataque, int defensa) //constructor para inicializae el item
    {
        NombreItem = nombre;
        Ataque = ataque;
        Defensa = defensa;
    }

    // método para obtener el total de ataque sumando los valores de los items (la lista se creó en clase personajes)
    public static int ObtenerValorAtaque(List<Item> items)
    {
        int ataqueTotal = 0; //inicializamos el contador de ataque total en 0
        foreach (var item in items) //recorremos cada item en la lista
        {
            ataqueTotal += item.Ataque;
        }
        return ataqueTotal;
    }

    // Método para obtener el total de defensa sumando los valores de los items en la lista
    public static int ObtenerValorDefensa(List<Item> items)
    {
        int defensaTotal = 0;
        foreach (var item in items)
        {
            defensaTotal += item.Defensa;
        }
        return defensaTotal;
    }
}

