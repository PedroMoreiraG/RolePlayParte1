// See https://aka.ms/new-console-template for more information

{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un personaje para las pruebas
            Personaje pj = new Personaje("Hada", 100, new ChequeoRaza());
            ChequeoRaza chequeo = new ChequeoRaza();
            chequeo.Estadisticas(pj);

            // Mostrar estadísticas iniciales del personaje
            Console.WriteLine($"Estadísticas iniciales de {pj.Nombre}:");
            Console.WriteLine($"Ataque: {pj.Ataque}, Defensa: {pj.Defensa}");

            // Crear algunos items para agregar al personaje
            Item alas = new Item("Alas", 0, 50);
            Item escudo = new Item("Escudo", 0, 40);

            // Agregar la espada al personaje
            espada.agregar_item(pj);
            Console.WriteLine("\nDespués de equipar la espada:");
            Console.WriteLine($"Ataque: {pj.Ataque}, Defensa: {pj.Defensa}");

            // Agregar el escudo al personaje
            escudo.agregar_item(pj);
            Console.WriteLine("\nDespués de equipar el escudo:");
            Console.WriteLine($"Ataque: {pj.Ataque}, Defensa: {pj.Defensa}");

            // Intentar agregar de nuevo la espada (debe mostrar un mensaje de que ya está equipada)
            espada.agregar_item(pj);

            // Quitar la espada
            espada.quitar_item(pj);
            Console.WriteLine("\nDespués de quitar la espada:");
            Console.WriteLine($"Ataque: {pj.Ataque}, Defensa: {pj.Defensa}");

            // Intentar quitar la espada de nuevo (debe mostrar un mensaje de que no está equipada)
            espada.quitar_item(pj);
        }
    }
}

