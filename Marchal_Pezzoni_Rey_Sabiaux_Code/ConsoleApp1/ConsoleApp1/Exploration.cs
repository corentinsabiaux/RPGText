using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Exploration
{
    public List<string> nameEvents = new List<string>();
    public Combat fight;
    public int donjon;
    public bool donjonFini = false;


    public void InitializeDonjon(int nbDonjon)
    {
        nameEvents.Clear();
        donjon = nbDonjon;
        
        //déclaration des évènements
        nameEvents.Add("Vous croisez un joli rat");
        nameEvents.Add("Vous évitez de justesse un piège");
        nameEvents.Add("Vous êtes perdu");
        nameEvents.Add("Vous savourez un délicieux champignon");
        nameEvents.Add("combat");
        nameEvents.Add("Vous consultez votre carte et retrouvez votre chemin");
        nameEvents.Add("combat");
        nameEvents.Add("combat");
        nameEvents.Add("Vous trouvez un passage secret");
        nameEvents.Add("combat");

        Shuffle(nameEvents); //change l'ordre des évènements

    }

    public void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        Random calcul = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId));
    
        while (n > 1) //intervertit les emplacements de la liste jusqu'à avoir tout mélangé
        {
            n--;
            int k = calcul.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public void Move(int room)
    {
        if (room < nameEvents.Count) //tant qu'on a pas exploré toutes les rooms
            Console.WriteLine("Appuyez sur la flèche du haut pour avancer");
        else
        {
            EventBoss(donjon);
            Console.WriteLine("Vous quittez le donjon.");
        }


        while (Console.ReadKey().Key == ConsoleKey.UpArrow && room < nameEvents.Count) //si on avance et qu'on est pas au fond du donjon
        {
            Console.WriteLine("->"); //signaler l'avancement
            EventAtRoom(room); //faire l'event de la room où on est
            room = room + 1; //avancer d'une salle
        }

        if (!donjonFini) //la fonction est rappelée tant qu'on a pas fini le donjon
            Move(room);
    }

    public void EventAtRoom(int room)
    {
        if (room < nameEvents.Count) //si n° de la salle < nombre d'event
            Event(nameEvents[room]); //lancer l'event de la room avec le nom de l'event en paramètre
    }

    public void Event(string eventText)
    {
        if (eventText == "combat") //si combat, lancer combat
        {
            EventFight(new Random().Next(0, 1));
        }
        else //on affiche juste le texte de l'event
        {
            Console.WriteLine(eventText);
        }
    }

    public void EventFight(int nmiIntensity)
    {
        Enemy nmi = new Enemy();
        nmi.Init(nmiIntensity); //on initialise un ennemi plus ou moins fort selon la variable donnée

        fight.Fight(nmi); //attaquer l'ennemi généré
    }

    public void EventBoss(int djn)
    {
        switch (djn) //djn = donjon
        {
            //prevoit l'event de boss personnalisé selon le donjon où l'on est
            case 1:
                EventBoss1();
                break;
            case 2:
                EventBoss2();
                break;
            case 3:
                EventBoss3();
                break;
            case 4:
                EventBoss4();
                break;
            
        }
        Console.WriteLine("Vous croisez un orc polygame.");
        EventFight(1);
        donjonFini = true;
    }

    public void EventBoss1()
    {
        //possibilité de faire un boss pour le donjon 1
    }
    public void EventBoss2()
    {
        //possibilité de faire un boss pour le donjon 2
    }
    public void EventBoss3()
    {
        //possibilité de faire un boss pour le donjon 3
    }
    public void EventBoss4()
    {
        //possibilité de faire un boss pour le donjon 4
    }
}
