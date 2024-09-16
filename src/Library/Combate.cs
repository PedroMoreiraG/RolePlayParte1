namespace Library;

public class Combate
{
    //Creamos atacar personaje
    public void atacar_personaje(Personaje pj1, Personaje pj2)
    {
        if (pj2.Vida > 0)
        {
            int dano = pj1.Ataque / (1 + pj2.Defensa / 100); //Una formula para aplicar defensa a un ataque
            
            pj2.Vida -= dano;
            
            if (pj2.Vida < 0)
            {
                pj2.Vida = 0;
            }

            Console.WriteLine($"{pj1.Nombre} ataco a {pj2.Nombre} causando {dano} de daño. Vida restante de {pj2.Nombre}: {pj2.Vida}");
        }
        else
        {
            Console.WriteLine($"El personaje {pj2.Nombre} ya no tiene vida");
        }
    }
    
    
    //Restaura su vida a 100%
    public int curar_personaje(Personaje pj)
    {
        return pj.Vida = 100;
    }
    
}