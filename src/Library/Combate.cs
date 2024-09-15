namespace Library;

public class Combate
{
    
    
    public void atacar_personaje(Personaje pj1, Personaje pj2)
    {
        if (pj1.Vida > pj2.Ataque)
        {
            pj2.Vida -= pj1.Ataque;
        }
        else
        {
            Console.WriteLine("El personaje " + pj2.Nombre + " ya no tiene vida");
        }
    }
    
    
    public int curar_personaje(Personaje pj)
    {
        return pj.Vida = pj.Vida_Inicial;
    }
    
}