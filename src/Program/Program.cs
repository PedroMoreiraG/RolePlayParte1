using Library;

class Program
{
    static void Main()
    {
        Personaje pj1 = new Personaje("Luis", "Mago");
        Personaje pj2 = new Personaje("Edison", "Guerrero");
        Personaje pj3 = new Personaje("Lugano", "Enano");


        Personaje error = new Personaje("Diego", "Error");
        
        Item item1 = new Item("Espada", 150, 0);
        Item item2 = new Item("Escudo", 0, 40);


        Item item5 = new Item("Armadura", 0, 50);
        Item item6 = new Item("Hacha", 100, 0);
        item1.agregar_item(pj1);
        item2.quitar_item(pj1);
        
        
        item5.agregar_item(pj3);
        item6.quitar_item(pj3);     

        Combate combate = new Combate();
        combate.atacar_personaje(pj1,pj2);
        combate.atacar_personaje(pj1,pj2);
    }
}