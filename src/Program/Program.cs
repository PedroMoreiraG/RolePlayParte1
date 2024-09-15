using System;
using Library;

class Program
{
    static void Main()
    {
        Personaje pj1 = new Personaje("Luis", "Mago");
        Personaje pj2 = new Personaje("Edison", "Guerrero");

        Item item1 = new Item("Espada", 50, 0);
        Item item2 = new Item("Escudo", 0, 40);

        Combate combate = new Combate();
        combate.atacar_personaje(pj1,pj2);
    }
}