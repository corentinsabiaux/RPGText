using System;

public class Combat
{
    public Player player;
    Enemy currentNMI;

    public void Fight(Enemy nmi)
    {
        currentNMI = nmi; //signale l'ennemi actuellement combattu
        Console.WriteLine("Ennemi en vue !!! A l'attaque !!!");

        while (player.pv > 0 && nmi.pv > 0) //tant que les deux adversaires sont vivants
        {
            Console.WriteLine("Appuyez espace pour frapper");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar) //combat avec la barre espace
            {
                if (player.isCritical()) //si le coup est critique
                {
                    Console.WriteLine("Critical hit !");
                    Taper(player.criticalDamage);   //dégâts plus élévés
                }
                else //dégâts normaux
                {
                    Taper(player.damage);
                } 
                degatsRecus(nmi.damage); //dégâts reçus
            }
            if(player.pv > 0 && currentNMI.pv > 0) //n'afficher que si les deux sont en vie
                Console.WriteLine("Il vous reste " + player.pv + " points de vie, et " + nmi.pv + " points à l'ennemi");
        }

    }
    void Taper(int dgts)
    {
        currentNMI.pv -= dgts; //l'ennemi prend les dégâts
        Console.WriteLine("Vous infligez "+ dgts+" points de dégats");
        if (currentNMI.pv <= 0) //si l'ennemi est K.O.
        {
            currentNMI.isDead = true;
            Console.WriteLine("Vous avez bravement vaincu votre adversaire...!!");
        }
    }
    void degatsRecus(int dgts)
    {
        player.pv -= dgts; //le joueur prend les dégâts
        Console.WriteLine("Vous prenez " + dgts + " points de dégats");
        if (player.pv <= 0) //si tu es mort
        {
            player.isDead = true;
            Console.WriteLine("Tu es mort misérablement..");
        }
    }
}
