namespace Library;

public class ChequeoRazas
{
    public void Estadisticas(Personaje pj1)
    {
        if (pj1.Raza == "Mago")
        {
            pj1.Ataque = 300;
            pj1.Defensa = 150;
        }
    }
}   