using System;

public static class Statics // contiendras les fonctions que tout le monde veut
{

    public static void Test() //static = accessible par tout le monde
    {
        string key;

        //Console.WriteLine("test"); // ceci est un debug
        ///WriteLine("texte"); //ceci est un message dans la console

        //key = Console.ReadLine(); // entrer valeur
        ///Console.ReadKey() //variante, a eviter pour l'instant

        Console.WriteLine("Entrer valeur");
        key = Console.ReadLine();
        Console.WriteLine("Vous avez tapé " + key);
        Console.WriteLine("Tapez exit");
        Console.ReadLine();
        // s'arrête automatiquement une fois le programme fini
    }
}
