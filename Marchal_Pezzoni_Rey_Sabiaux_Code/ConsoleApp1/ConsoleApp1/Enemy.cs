using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Enemy : Entity
{
    public void Init(int type)
    {
        if (type == 0) //difficulté normale
        {
            pv = 5;
            damage = 1;
            shield = 0;
        }
        else //ennemi un peu plus retors
        {
            pv = 7;
            damage = 3;
            shield = 0;
        }

    }
}

