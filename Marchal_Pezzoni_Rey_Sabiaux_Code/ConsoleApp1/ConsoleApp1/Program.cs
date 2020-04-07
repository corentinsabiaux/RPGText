using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Starter
{
    static void Main(string[] args)
    {
        Combat systemeCombat = new Combat(); //on instancie le combat
        Exploration donjon = new Exploration(); //on instancie le systeme donjon/exploration
        Player player = new Player(); //on instancie le player
        player.Init(); //on initialise le player
        systemeCombat.player = player; //on dit au systeme de combat qui est le player
        donjon.fight = systemeCombat; //on passe le systeme de combat dans le systeme d'exploration
        int room = 0;
        donjon.InitializeDonjon(1); //premier donjon
        donjon.Move(room); //entrée dans le donjon


        Console.WriteLine("Tapez enter pour exit"); //fin du code
        Console.ReadLine();

    }
}

