namespace Library;

public class ChequeoRazas
{
    // Método que asigna estadísticas
    public void Estadistica(Personaje pj)
    {
        int bandera = 1;
        if (pj.Raza == "Mago") 
        { 
            pj.Ataque = 70; 
            pj.Defensa = 30;
        }
        else if (pj.Raza == "Enano") 
        { 
            pj.Ataque = 50; 
            pj.Defensa = 60;
        }
        else if (pj.Raza == "Elfo") 
        { 
            pj.Ataque = 55; 
            pj.Defensa = 55;
        }
        else if (pj.Raza == "Guerrero") 
        { 
            pj.Ataque = 60; 
            pj.Defensa = 50;
        }
        else if (pj.Raza == "Hada") 
        { 
            pj.Ataque = 65; 
            pj.Defensa = 45;
        }
        else
        {
            Console.WriteLine($"La raza del personaje llamado {pj.Nombre} no existe");
            bandera -= 1;
        }

        if (bandera == 1)
        {
            
            Console.WriteLine($"Personaje creado correctamente, Nombre: {pj.Nombre}, Raza: {pj.Raza}");
        }
    }
}
   