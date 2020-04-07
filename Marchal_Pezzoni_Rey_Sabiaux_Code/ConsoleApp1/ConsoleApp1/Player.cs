using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player : Entity
{
    public int tauxCritical = 4; //probabilité
    public int criticalDamage = 5;

    public void Init()
    {
        pv = 15;
        damage = 2;
        shield = 0;
        isDead = false;
    }

    public bool isCritical() //gère les coups critiques
    {
        int randomNumber;
        Random randm = new Random();

        randomNumber = randm.Next(1, tauxCritical); //prend une valeur aléatoire entre 1 et taux critical

        if (randomNumber == 1) //seul cas où on considère que le coup est critique
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

