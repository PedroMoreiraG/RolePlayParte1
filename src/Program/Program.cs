using Library;

class Program
{
    static void Main()
    {
        Personaje pj1 = new Personaje("Luis", "Mago");
        Personaje pj2 = new Personaje("Edison", "Guerrero");
        Personaje error = new Personaje("Diego", "Error");
        Personaje pj3 = new Personaje("Muslera", "Hada");
        
        Item item1 = new Item("Espada", 150, 0);
        Item item2 = new Item("Escudo", 0, 40);
        Item item3 = new Item("Alas", 0, 50);
        Item item4 = new Item("Varita", 60, 10);
        item1.agregar_item(pj1);
        item2.quitar_item(pj1);
        item3.agregar_item(pj3);
        item3.quitar_item(pj3);

        Combate combate = new Combate();
        combate.atacar_personaje(pj1,pj2);
        combate.atacar_personaje(pj1,pj2);
        combate.atacar_personaje(pj3, pj1);
    }
}