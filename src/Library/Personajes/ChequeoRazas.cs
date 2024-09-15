using System;
using System.Collections;
using Library;

namespace Library
{
    public class ChequeoRazas
    {
        // Método que asigna estadísticas y hechizos al personaje
         public Dictionary<string, int> Estadistica(Personaje pj1)
        {
           public Dictionary <string, int> hechizos = null; // Inicializamos la lista de hechizos como null

            if (pj1.Raza == "Mago")
            {
                pj1.Ataque = 390;
                pj1.Defensa = 110;

                // Se hace una ArrayList si solo si se elige Mago
                hechizos = new Dictionary<string, int>()
                {
                    { "Bola de Fuego", 100 },
                     { "Bola de hielo", 90 },
                     { "Fuego ", 50 },
                };
            }

            return hechizos; // Devolvemos la lista de hechizos si es un mago, si no, retorna null
        }
    }

}
public void ElegirHechizo(Personaje pj1)
{
    ChequeoRazas chequeo = new ChequeoRazas();
    Dictionary<string, int> hechizos = chequeo.Estadistica(pj1); // Obtengo todos los hechizos del personaje

    if (hechizos != null && pj1.Raza == "Mago") // Verifico si es mago y tiene hechizos
    {
        Random rand = new Random();
        
        // Convertimos las claves del diccionario en una lista para seleccionar un hechizo al azar
        List<string> keys = new List<string>(hechizos.Keys);
        int randomIndex = rand.Next(keys.Count); // Seleccionamos un índice aleatorio
        var hechizoElegido = keys[randomIndex];  // Obtengo el hechizo random elegido
        var danoHechizo = hechizos[hechizoElegido];  // Obtengo el daño del hechizo elegido

        Console.WriteLine($"El mago {pj1.Raza} eligió el hechizo: {hechizoElegido} con daño de {danoHechizo}");
    }
    else
    {
        Console.WriteLine("El Personaje no eligió ninguno, o se quedó sin hechizos");
    }
}

